﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CMS.Savings.Transaction.Controller
{
    class TerminationController
    {
        Savings.Transaction.Model.TerminationModel terminationModel;
        Savings.Transaction.View.MemberTermination termination;

        double totalPenalty = 0;
        double totalInterest = 0;
        double totalBalance = 0;
        String accountNo = String.Empty;

        public TerminationController(Transaction.Model.TerminationModel terminationModel, Transaction.View.MemberTermination termination, SavingsMenu savingsMenu)
        {
            this.terminationModel = terminationModel;
            this.termination = termination;
            this.termination.setBtnSaveEventHandler(this.btnSave);
            this.termination.setBtnCancelEventHandler(this.btnCancel);
            this.termination.setTxtAccountNameEventHandler(this.typeSearchMember);
            this.termination.setTxtAccountNoEventHandler(this.typeSearchMember);
            this.termination.classGridSearch(this.terminationModel.selectActiveMember());
            this.termination.setDataSearchEventHandler(this.dataSearch_CellClick);
            this.termination.MdiParent = savingsMenu;
            this.termination.Show();
            if(this.terminationModel.checkEmpty!=0)this.termination.noRowsSelected();
            this.terminationModel.checkEmpty = 0;
            this.termination.clearFields();
        }

        public void btnSave(object args, EventArgs e)
        {
            Boolean checkSavings = false;
            Boolean checkTimeDeposit = false;
            String errorMessage = "Cannot Terminate Member." + Environment.NewLine + Environment.NewLine;
            if (this.termination.getSavings() != "None")
            {
                checkSavings = false;
                errorMessage += "Member has Active Savings Account." + Environment.NewLine + "Please Terminate Savings Account first." + Environment.NewLine;
            }
            else
            {
                checkSavings = true;
            }
            if (this.termination.getTextTimeDeposit() > 0)
            {
                checkTimeDeposit = false;
                errorMessage += "Member has Time Deposit/s." + Environment.NewLine + "Please Withdraw All Time Deposit/s first.";
            }
            else
            {
                checkTimeDeposit = true;
            }
            if (checkSavings && checkTimeDeposit)
            {
                DataGridViewRow selectedData = this.termination.getSelected();
                String accountNo = selectedData.Cells["Account No."].Value.ToString();
                String reason = this.termination.getReason();
                String details = this.termination.getDetails();
                double totalRefundables = this.termination.getShareCapital();
                double netRefunds = totalRefundables - this.termination.getNetRefunds();
                CultureInfo ph = new CultureInfo("en-PH");
                if (netRefunds < 0)
                {
                    DialogResult dr = MessageBox.Show("Member still has to pay " + netRefunds.ToString("c", ph) + " to continue termination. Proceed?", "Member Termination", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    if (dr == DialogResult.Yes)
                    {
                        new View.TerminationPayment(accountNo, reason, details, netRefunds, this.termination, this.terminationModel).Show();
                    }
                }
                else
                {
                    if (this.terminationModel.insertTermination(reason, details, accountNo) != 0)
                    {
                        if (this.terminationModel.clearLoans(accountNo) != 0)
                        {
                            MessageBox.Show("Member Termination Success.", "Membership Termination", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.termination.classGridSearch(this.terminationModel.selectActiveMember());
                            this.termination.clearFields();
                        }
                        else
                        {
                            MessageBox.Show("Clear Loans Failed.", "Membership Termination", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Member Termination Failed.", "Membership Termination", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Membership Termination", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnCancel(object args, EventArgs e)
        {
            this.termination.clearFields();
        }

        public void btnSearchMember(object args, EventArgs e)
        {   
            bool getSearchType = this.termination.getSearchType();

            if (getSearchType)
            {
                this.termination.classGridSearch(this.terminationModel.searchMemberByName(this.termination.getSearch()));
                if (this.termination.checkIfEmpty())
                {
                    
                    this.termination.selectFeesBySearch();
                }
                else {
                    MessageBox.Show("Data not found.", "Membership Termination", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.termination.classGridSearch(this.terminationModel.selectActiveMember());
                    if (this.terminationModel.checkEmpty != 0) this.termination.noRowsSelected();
                    this.termination.clearFields();
                }
            }

            else {
                this.termination.classGridSearch(this.terminationModel.searchMemberByAccount(this.termination.getSearch()));
                if (this.termination.checkIfEmpty())
                {
                    
                    this.termination.selectFeesBySearch();
                }
                else
                {
                    MessageBox.Show("Data not found.", "Membership Termination", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.termination.classGridSearch(this.terminationModel.selectActiveMember());
                    if (this.terminationModel.checkEmpty != 0) this.termination.noRowsSelected();
                    this.termination.clearFields();
                }
            }
        }

        private void dataSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            totalBalance = 0;
            this.termination.selectAnotherMember();
            DataGridViewRow selectedData = this.termination.getSelected();
            accountNo = selectedData.Cells["Account No."].Value.ToString();
            this.termination.setSavingsBalance(this.terminationModel.selectSavingsAccount(accountNo));
            this.termination.setTextTimeDeposit(this.terminationModel.selectMemberTimeDeposit(accountNo).ToString());
            double shareCapital = this.terminationModel.selectCurrentShareCapital(accountNo);
            this.termination.setShareCapitalBalance(shareCapital.ToString());
                //this.terminationModel.selectRemainingBalance(accountNo);
            double balFromRegLoans = this.terminationModel.selectRemainingBalance(accountNo);
            totalBalance += balFromRegLoans;

            DataSet setAmnestizedLoans = this.terminationModel.selectUnpaidAmnestiedLoans(accountNo);

            for (int i = 0; i < setAmnestizedLoans.Tables[0].Rows.Count; i++) 
            {
                totalBalance +=this.terminationModel.selectLoanBalanceFromAmnestied(int.Parse(setAmnestizedLoans.Tables[0].Rows[i][0].ToString()));
            }

            DataSet setLoans = this.terminationModel.selectUnpaidLoans(accountNo);
            for (int j = 0; j < setLoans.Tables[0].Rows.Count; j++)
            {
                this.getInterestAndPenalty(int.Parse(setLoans.Tables[0].Rows[j][0].ToString()), int.Parse(setLoans.Tables[0].Rows[j][1].ToString()));
            }

            
            this.termination.setLoanBalance(totalBalance.ToString());           
            this.termination.setNetRefunds((shareCapital - totalBalance).ToString());
            this.termination.enablePanel1();
        }

        public void typeSearchMember(object args, EventArgs e)
        {
            bool getSearchType = this.termination.getSearchType();
            if (getSearchType)
            {
                this.termination.classGridSearch(this.terminationModel.searchMemberByName(this.termination.getSearch()));
                if (this.termination.checkIfEmpty())
                {

                    this.termination.selectFeesBySearch();
                }
               
            }

            else
            {
                this.termination.classGridSearch(this.terminationModel.searchMemberByAccount(this.termination.getSearch()));
                if (this.termination.checkIfEmpty())
                {

                    this.termination.selectFeesBySearch();
                }

            }
        }

        public void getInterestAndPenalty(int lappId, int loanTypeId) 
        {
            totalInterest = 0;
            totalPenalty = 0;

            Dictionary<String, int> listOfInterestDates = new Dictionary<String, int>();
            Dictionary<String, int> finalListOfInterestDates = new Dictionary<String, int>();

            String maturityDate = this.terminationModel.selectMaturityDate(lappId);
            String interestDate = (DateTime.Parse(maturityDate).AddDays(1)).ToString();
            String[] interest = this.terminationModel.selectInterestPerLoanType(loanTypeId).Split(' ');

            if (DateTime.Now > DateTime.Parse(maturityDate) && interest[0] != "")
            {
                String interestRateStatus = interest[0];
                double interestRate = Convert.ToDouble(interest[1]);
                String per = interest[2];

                if (interestRateStatus == "%") { interestRate *= 0.01; }


                if (per == "month")
                {
                    for (String a = interestDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddMonths(1)).ToString())
                    {
                        listOfInterestDates.Add(a, 0);
                    }

                    foreach (KeyValuePair<String, int> pair in listOfInterestDates)
                    {
                        String firstDate = DateTime.Parse(pair.Key).AddDays(-1).ToString();
                        String secondDate = DateTime.Parse(pair.Key).AddMonths(1).ToString();
                        int i = this.terminationModel.selectPaymentDatesWithInterestRates(lappId, firstDate, secondDate);

                        if (i > 0)
                        {
                            finalListOfInterestDates.Add(pair.Key, 0);
                        }
                    }

                    String last = String.Empty;
                    try
                    {
                        last = finalListOfInterestDates.Keys.Last();
                    }
                    catch (Exception) { last = maturityDate; }
                    foreach (KeyValuePair<String, int> pair in listOfInterestDates)
                    {
                        if (DateTime.Parse(pair.Key) > DateTime.Parse(last))
                        {
                            double finalInterest = 0;
                            double grantedLoanAmount = this.terminationModel.selectGrantedLoanAmount(lappId);
                            String[] paymentDur = this.terminationModel.selectPaymentDurationPerApplication(lappId).Split(' ');
                            int pdValue = int.Parse(paymentDur[0]);
                            String pdStatus = paymentDur[1];
                            if (interestRateStatus == "%")
                            {
                                if (pdStatus == "week/s")
                                {
                                    finalInterest = grantedLoanAmount * ((interestRate / 4) * pdValue);
                                }
                                else if (pdStatus == "month/s")
                                {
                                    finalInterest = grantedLoanAmount * interestRate * pdValue;
                                }
                                else if (pdStatus == "year/s")
                                {
                                    finalInterest = grantedLoanAmount * interestRate * 12 * pdValue;
                                }
                            }

                            else if (interestRateStatus == "Php")
                            {
                                if (pdStatus == "week/s")
                                {
                                    finalInterest = (interestRate / 4) * pdValue;
                                }
                                else if (pdStatus == "month/s")
                                {
                                    finalInterest = interestRate * pdValue;
                                }
                                else if (pdStatus == "year/s")
                                {
                                    finalInterest = interestRate * 12 * pdValue;
                                }
                            }
                            totalInterest += finalInterest;
                        }
                    }

                }

                else if (per == "annum")
                {
                    for (String a = interestDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddYears(1)).ToString())
                    {
                        listOfInterestDates.Add(a, 0);
                    }

                    foreach (KeyValuePair<String, int> pair in listOfInterestDates)
                    {
                        String firstDate = DateTime.Parse(pair.Key).AddDays(-1).ToString();
                        String secondDate = DateTime.Parse(pair.Key).AddYears(1).ToString();
                        int i = this.terminationModel.selectPaymentDatesWithInterestRates(lappId, firstDate, secondDate);

                        if (i > 0)
                        {
                            finalListOfInterestDates.Add(pair.Key, 0);
                        }
                    }

                    String last = String.Empty;
                    try
                    {
                        last = finalListOfInterestDates.Keys.Last();
                    }
                    catch (Exception) { last = maturityDate; }
                    foreach (KeyValuePair<String, int> pair in listOfInterestDates)
                    {
                        if (DateTime.Parse(pair.Key) > DateTime.Parse(last))
                        {
                            double finalInterest = 0;
                            double grantedLoanAmount = this.terminationModel.selectGrantedLoanAmount(lappId);
                            String[] paymentDur = this.terminationModel.selectPaymentDurationPerApplication(lappId).Split(' ');
                            int pdValue = int.Parse(paymentDur[0]);
                            String pdStatus = paymentDur[1];
                            if (interestRateStatus == "%")
                            {
                                if (pdStatus == "week/s")
                                {
                                    finalInterest = grantedLoanAmount * ((interestRate / 52) * pdValue);
                                }
                                else if (pdStatus == "month/s")
                                {
                                    finalInterest = grantedLoanAmount * ((interestRate / 12) * pdValue);
                                }
                                else if (pdStatus == "year/s")
                                {
                                    finalInterest = grantedLoanAmount * interestRate * pdValue;
                                }
                            }
                            else if (interestRateStatus == "Php")
                            {
                                if (pdStatus == "week/s")
                                {
                                    finalInterest = (interestRate / 52) * pdValue;
                                }
                                else if (pdStatus == "month/s")
                                {
                                    finalInterest = (interestRate / 12) * pdValue;
                                }
                                else if (pdStatus == "year/s")
                                {
                                    finalInterest = interestRate * pdValue;
                                }
                            }
                            totalInterest += finalInterest;
                        }
                    }
                }
            }

            totalBalance += totalInterest;

            DataSet amorSet = this.terminationModel.selectAmortizations(accountNo, lappId);

            for (int j = 0; j < amorSet.Tables[0].Rows.Count; j++)
            {
                DataSet ds2 = this.terminationModel.selectMonthlyAmortization(lappId);
                double monthlyAmortization = double.Parse(ds2.Tables[0].Rows[0][0].ToString());
                String loanDurationStatus = ds2.Tables[0].Rows[0][1].ToString();
                if (loanDurationStatus == "week/s") { monthlyAmortization *= 4; }
                else if (loanDurationStatus == "year/s") { monthlyAmortization /= 12; }
                double grantedLoanAmount = this.terminationModel.selectGrantedLoanAmount(lappId);
                double remainingBalance = this.terminationModel.selectCurrentBalance(lappId);

                String dueDate = amorSet.Tables[0].Rows[j][3].ToString();
                double amortizationAmount = double.Parse(amorSet.Tables[0].Rows[j][2].ToString());

                DataSet ds = this.terminationModel.selectPenaltiesPerLoanType(loanTypeId);
                if (ds.Tables[0].Rows.Count == 0 || DateTime.Parse(dueDate) > DateTime.Now)
                {
                    totalPenalty = 0;
                }

                else
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        double initialPenalty = 0;
                        String finalDate = String.Empty;
                        String penaltyName = ds.Tables[0].Rows[i][0].ToString();
                        int gracePeriod = int.Parse(ds.Tables[0].Rows[i][1].ToString());
                        double amount = double.Parse(ds.Tables[0].Rows[i][2].ToString());
                        String amountStatus = ds.Tables[0].Rows[i][3].ToString();
                        String deductTo = ds.Tables[0].Rows[i][4].ToString();
                        int duration = int.Parse(ds.Tables[0].Rows[i][5].ToString());
                        String durationStatus = ds.Tables[0].Rows[i][6].ToString();

                        if (durationStatus == "week/s") { duration = duration * 7; }
                        //TimeSpan diffDate = DateTime.Now.Subtract(DateTime.Parse(dueDate));
                        //int totalDays = (int)diffDate.TotalDays;
                        //totalDays -= gracePeriod;
                        String newDate = (DateTime.Parse(dueDate).AddDays(gracePeriod)).ToString();

                        if (amountStatus == "%") { amount = amount * 0.01; }

                        finalDate = DateTime.Parse(newDate).AddDays(1).ToString();

                        if (deductTo == "monthly amortization")
                        {
                            if (durationStatus == "month/s")
                            {
                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddMonths(duration)).ToString())
                                {
                                    initialPenalty = amount * monthlyAmortization;
                                    totalPenalty += initialPenalty;

                                }
                            }
                            else
                            {
                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                {
                                    initialPenalty = amount * monthlyAmortization;
                                    totalPenalty += initialPenalty;

                                }
                            }
                        }
                        else if (deductTo == "remaining balance")
                        {
                            if (durationStatus == "month/s")
                            {
                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddMonths(duration)).ToString())
                                {
                                    initialPenalty = amount * remainingBalance;
                                    totalPenalty += initialPenalty;

                                }
                            }
                            else
                            {
                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                {
                                    initialPenalty = amount * remainingBalance;
                                    totalPenalty += initialPenalty;

                                }
                            }
                        }
                        else if (deductTo == "granted loan amount")
                        {
                            if (durationStatus == "month/s")
                            {
                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddMonths(duration)).ToString())
                                {
                                    initialPenalty = amount * grantedLoanAmount;
                                    totalPenalty += initialPenalty;

                                }
                            }
                            else
                            {
                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                {
                                    initialPenalty = amount * grantedLoanAmount;
                                    totalPenalty += initialPenalty;

                                }
                            }
                        }

                        else if (deductTo == String.Empty)
                        {
                            if (durationStatus == "month/s")
                            {
                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddMonths(duration)).ToString())
                                {
                                    initialPenalty = amount;
                                    totalPenalty += initialPenalty;

                                }
                            }
                            else
                            {
                                for (String a = finalDate; DateTime.Parse(a) <= DateTime.Now; a = (DateTime.Parse(a).AddDays(duration)).ToString())
                                {
                                    initialPenalty = amount;
                                    totalPenalty += initialPenalty;

                                }
                            }
                        }
                    }//end for loop




                }//end else

            }

            totalBalance += totalPenalty;
        }
    }
}