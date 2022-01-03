using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    {
        public static string WarningMessage(string s)
        {
            //Warning message Delegate
            return "You have exceeded 75% of your income";
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void incomeTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int BuyingOrRenting = -1;

            int CarOption = -1;

            double TotalExpense = 0;

            double BaseValue = 0;

            double AvailableMonthlyMoneyAfterCarRepayment = 0;

            double AvailableMonthlyMoneyWithoutCarRepayment = 0;

            double TotalCarRepayment = 0;

            double TotalCarMonthlyPayment = 0;

            string strTemp;

            double dblTemp = 0;

            double Income = 0;

            double TaxDeduction = 0;

            int AccomodationOption = -1;

            Rent rent = new();

            //List declaration for expenditure
            List<CustomType> CarExpenses = new();

            List<ExpenseType> ExpensesList = new();

            //variable to store property price

            double TotalRepayment;

            double AvailableMonthlyMoney;

            //Expenses Array

            double[] ExpensesArray = new double[5];

            //Link to HomeLoan class

            HomeLoan homeLoan = new();


            Income = Convert.ToDouble(incomeTxt.Text);
            if (Income <= 0)
            {
                MessageBox.Show("Invalid Income, try again");
                incometax.Focus();
            }


            TaxDeduction = Convert.ToDouble(incometax.Text);

            if (TaxDeduction <= 0)
            {
                MessageBox.Show("Invalid Tax amount, try again");
                incometax.Focus();
            }


            ExpensesArray[0] = Convert.ToDouble(grocerytxt.Text);

            if (ExpensesArray[0] <= 0)
            {
                Console.WriteLine("Invalid grocery expense, try again");
                grocerytxt.Focus();
            }

            ExpensesArray[1] = Convert.ToDouble(lightandwatertxt.Text);

            if (ExpensesArray[1] <= 0)
            {
                Console.WriteLine("Invalid input, try again");

            }

            ExpensesArray[2] = Convert.ToDouble(traveltxt.Text);

            if (ExpensesArray[2] <= 0)
            {
                Console.WriteLine("Invalid input, try again");

            }


            ExpensesArray[3] = Convert.ToDouble(cellphonetxt.Text);

            if (ExpensesArray[3] <= 0)
            {
                Console.WriteLine("Invalid input, try again");

            } 

            ExpensesArray[4] = Convert.ToDouble(othertxt.Text);

            if (ExpensesArray[4] <= 0)
            {
                MessageBox.Show("Invalid input, try again");
            }

            if(rentProperty.IsChecked == true)
            {
                AccomodationOption = 1;
                BuyingOrRenting = 1;

                rent.Price = Convert.ToDouble(propertyPricetxt.Text);

                if (rent.Price <= 0)
                {
                    MessageBox.Show("Invalid input, try again");
                    propertyPricetxt.Focus();
                }


                AvailableMonthlyMoney = Income - TaxDeduction - ExpensesArray[0] - ExpensesArray[1] - ExpensesArray[2] - ExpensesArray[3] - ExpensesArray[4] - rent.Price;

                MessageBox.Show("Available monthly moneys R" + Math.Round(AvailableMonthlyMoney, 2));

            }
            else if (buyProperty.IsChecked == true) {

                AccomodationOption = 0;

                BuyingOrRenting = 0;

                //Input validation
                homeLoan.Price = Convert.ToDouble(propertyPricetxt.Text);

                if (homeLoan.Price <= 0)
                {
                    MessageBox.Show("Invalid property rent/price value");
                    propertyPricetxt.Focus();
                }
                
                //Input validation
               
                homeLoan.TotalDeposit = Convert.ToDouble(depositAmountTxt.Text);

                if (homeLoan.TotalDeposit <= 0)
                {
                    MessageBox.Show("Invalid input, try again");
                    depositAmountTxt.Focus();
                }

                //Input validation
                
                homeLoan.InterestRate = Convert.ToDouble(interestRateTxt.Text);

                if (homeLoan.InterestRate <= 0)
                {
                    Console.WriteLine("Invalid input, try again");

                }

                homeLoan.NumberOfMonths = Convert.ToInt32(propertyMonthstxt.Text);

                if (homeLoan.NumberOfMonths <= 0)
                {
                    MessageBox.Show("Invalid Number of months, try again");
                    propertyMonthstxt.Focus();
                }

                // print selected months
                OutputBlock.Inlines.Add(new Run("Your chosen number of months are:" + homeLoan.NumberOfMonths));

                //If property purchase is chosen,enter the amount of months to pay the loan 

                if (homeLoan.NumberOfMonths >= 240 && homeLoan.NumberOfMonths <= 360)
                {
                    //Calculation of homeloan repayment [A=P(1+in)]
                    TotalRepayment = homeLoan.CalculateTotalRepayment(homeLoan.Price, homeLoan.TotalDeposit, homeLoan.InterestRate, homeLoan.NumberOfMonths);

                    homeLoan.MonthlyRepayment = TotalRepayment / homeLoan.NumberOfMonths;

                    OutputBlock.Inlines.Add(new Run("Your monthly repayements are: R" + Math.Round(homeLoan.MonthlyRepayment, 2)));
                    OutputBlock.Inlines.Add(new Run("Your total repayment is: R" + Math.Round(TotalRepayment, 2)));

                    //If the homeloan repayments are more than 1/3 of the persons Salary ,the loan will not be approved
                    if (homeLoan.MonthlyRepayment > Income / 3)
                    {
                        MessageBox.Show("Your HomeLoan is not approved :(");
                    }
                    else
                    {
                        //Calculation for available moneys
                        AvailableMonthlyMoney = Income - TaxDeduction - ExpensesArray[0] - ExpensesArray[1] - ExpensesArray[2] - ExpensesArray[3] - ExpensesArray[4] - homeLoan.MonthlyRepayment;
                        OutputBlock.Inlines.Add(new Run("Your available moneys are: R" + Math.Round(AvailableMonthlyMoney, 2)));
                    }
                }
                else
                {
                    //Statement to return to the user if an incorrect number of months are chosen
                    MessageBox.Show("Incorrect Number of Months entered");
                    propertyMonthstxt.Focus();
                }
            }
            else
            {
                MessageBox.Show("Select a property option please!");
            }

            // Car purchase or not

            if (buyCar.IsChecked == true)
            {
                CarOption = 1;
            }
            else if (noCarButton.IsChecked == true)
            {
                CarOption = 0;
            }

            if (CarOption.Equals(1))
            {
                //To enter the brand and model of vehicle to purchase

                strTemp = carmodeltxt.Text;

                CarExpenses.Add(new CustomType(strTemp, 0.00));

                //Input for car price
                Console.WriteLine("Enter Purchase Price:");

                dblTemp = Convert.ToDouble(carPricetxt1.Text);

                if (dblTemp <= 0)
                {
                    MessageBox.Show("Invalid Car Price, try again");
                    carPricetxt1.Focus();
                }

                CarExpenses.Add(new CustomType(" ", dblTemp));

                //Input deposit amount
                dblTemp = Convert.ToDouble(depositCartxt.Text);

                if (dblTemp <= 0)
                {
                    MessageBox.Show("Invalid Deposit amount, try again");
                    depositCartxt.Focus();
                }


                CarExpenses.Add(new CustomType(" ", dblTemp));

                //Input interest rate
                dblTemp = Convert.ToDouble(carInteresteRatetxt.Text);

                if (dblTemp <= 0)
                {
                    MessageBox.Show("Invalid Car Intereste rate, try again");
                    carInteresteRatetxt.Focus();
                }

                // Input insurance amount
                CarExpenses.Add(new CustomType(" ", dblTemp));

                dblTemp = Convert.ToDouble(insuranceAmounttxt.Text);

                if (dblTemp <= 0)
                {
                    insuranceAmounttxt.Focus();
                }

                CarExpenses.Add(new CustomType(" ", dblTemp));

                //Calculation of car repayment over 5 years
                TotalCarRepayment = homeLoan.CalculateTotalRepayment(CarExpenses[1].d, CarExpenses[2].d, CarExpenses[3].d, 60);

                TotalCarMonthlyPayment = (TotalCarRepayment / 60) + CarExpenses[4].d;

                OutputBlock.Inlines.Add(new Run("Total monthly cost for car payment: R" + Math.Round(TotalCarMonthlyPayment, 2)));

                if (BuyingOrRenting.Equals(1))
                {
                    //To Display expenses with car repayment in decending order when renting a property
                    AvailableMonthlyMoneyAfterCarRepayment = Income - TaxDeduction - ExpensesArray[0] - ExpensesArray[1] - ExpensesArray[2] - ExpensesArray[3] - ExpensesArray[4] - rent.Price - TotalCarMonthlyPayment;

                    TotalExpense = TaxDeduction + ExpensesArray[0] + ExpensesArray[1] + ExpensesArray[2] + ExpensesArray[3] + ExpensesArray[4] + rent.Price + TotalCarMonthlyPayment;

                    ExpensesList.Add(new ExpenseType("Tax Deduction", TaxDeduction));
                    ExpensesList.Add(new ExpenseType("Groceries", ExpensesArray[0]));
                    ExpensesList.Add(new ExpenseType("Water and Lights", ExpensesArray[1]));
                    ExpensesList.Add(new ExpenseType("Travel Costs", ExpensesArray[2]));
                    ExpensesList.Add(new ExpenseType("Cell Phone and Telephone", ExpensesArray[3]));
                    ExpensesList.Add(new ExpenseType("Other Expenses", ExpensesArray[4]));
                    ExpensesList.Add(new ExpenseType("Rent", rent.Price));
                    ExpensesList.Add(new ExpenseType("Car Repayment", Math.Round(TotalCarMonthlyPayment, 2)));

                }
                else if (BuyingOrRenting.Equals(0))
                {
                    //To Display expenses with car repayment in decending order when buying a property
                    AvailableMonthlyMoneyAfterCarRepayment = Income - TaxDeduction - ExpensesArray[0] - ExpensesArray[1] - ExpensesArray[2] - ExpensesArray[3] - ExpensesArray[4] - homeLoan.MonthlyRepayment - TotalCarMonthlyPayment;

                    TotalExpense = TaxDeduction + ExpensesArray[0] + ExpensesArray[1] + ExpensesArray[2] + ExpensesArray[3] + ExpensesArray[4] + homeLoan.MonthlyRepayment + TotalCarMonthlyPayment;

                    ExpensesList.Add(new ExpenseType("Tax Deduction", TaxDeduction));
                    ExpensesList.Add(new ExpenseType("Groceries", ExpensesArray[0]));
                    ExpensesList.Add(new ExpenseType("Water and Lights", ExpensesArray[1]));
                    ExpensesList.Add(new ExpenseType("Travel Costs", ExpensesArray[2]));
                    ExpensesList.Add(new ExpenseType("Cell Phone and Telephone", ExpensesArray[3]));
                    ExpensesList.Add(new ExpenseType("Other Expenses", ExpensesArray[4]));
                    ExpensesList.Add(new ExpenseType("HomeLoan Repayment", Math.Round(homeLoan.MonthlyRepayment, 2)));
                    ExpensesList.Add(new ExpenseType("Car Repayment", Math.Round(TotalCarMonthlyPayment, 2)));
                }


                //Delegate for notifying the user that their expenses are equal or greater than 75% of their income
                BaseValue = Income * 0.75;

                if (TotalExpense > BaseValue)
                {
                    MessageBox.Show("You have exeeded 75% of your income!");
                }
                //Expense list to display in decending order
                ExpensesList.Sort(delegate (ExpenseType x, ExpenseType y)
                {
                    return y.value.CompareTo(x.value);
                });

                OutputBlock.Inlines.Add(new Run("Your available moneys after vehicle repayments are R" + Math.Round(AvailableMonthlyMoneyAfterCarRepayment, 2) + "\n"));
                OutputBlock.Inlines.Add(new Run(String.Join(Environment.NewLine, ExpensesList)));
            }
            else if (CarOption.Equals(0))
            {
                //Calculation of available moneys without buying a vehicle but renting a property
                if (BuyingOrRenting.Equals(1))
                {
                    AvailableMonthlyMoneyWithoutCarRepayment = Income - TaxDeduction - ExpensesArray[0] - ExpensesArray[1] - ExpensesArray[2] - ExpensesArray[3] - ExpensesArray[4] - rent.Price;

                    TotalExpense = TaxDeduction + ExpensesArray[0] + ExpensesArray[1] + ExpensesArray[2] + ExpensesArray[3] + ExpensesArray[4] + rent.Price;

                    ExpensesList.Add(new ExpenseType("Tax Deduction", TaxDeduction));
                    ExpensesList.Add(new ExpenseType("Groceries", ExpensesArray[0]));
                    ExpensesList.Add(new ExpenseType("Water and Lights", ExpensesArray[1]));
                    ExpensesList.Add(new ExpenseType("Travel Costs", ExpensesArray[2]));
                    ExpensesList.Add(new ExpenseType("Cell Phone and Telephone", ExpensesArray[3]));
                    ExpensesList.Add(new ExpenseType("Other Expenses", ExpensesArray[4]));
                    ExpensesList.Add(new ExpenseType("Rent", rent.Price));

                }
                else if (BuyingOrRenting.Equals(0))
                {

                    //Calculation of available moneys without buying a vehicle but purchasing a property
                    AvailableMonthlyMoneyWithoutCarRepayment = Income - TaxDeduction - ExpensesArray[0] - ExpensesArray[1] - ExpensesArray[2] - ExpensesArray[3] - ExpensesArray[4] - homeLoan.MonthlyRepayment;

                    TotalExpense = TaxDeduction + ExpensesArray[0] + ExpensesArray[1] + ExpensesArray[2] + ExpensesArray[3] + ExpensesArray[4] + homeLoan.MonthlyRepayment;

                    ExpensesList.Add(new ExpenseType("Tax Deduction", TaxDeduction));
                    ExpensesList.Add(new ExpenseType("Groceries", ExpensesArray[0]));
                    ExpensesList.Add(new ExpenseType("Water and Lights", ExpensesArray[1]));
                    ExpensesList.Add(new ExpenseType("Travel Costs", ExpensesArray[2]));
                    ExpensesList.Add(new ExpenseType("Cell Phone and Telephone", ExpensesArray[3]));
                    ExpensesList.Add(new ExpenseType("Other Expenses", ExpensesArray[4]));
                    ExpensesList.Add(new ExpenseType("HomeLoan Repayment", Math.Round(homeLoan.MonthlyRepayment, 2)));
                }


                BaseValue = Income * 0.75;

                if (TotalExpense > BaseValue)
                {
                    MessageBox.Show("You have exceeded 75% of your income");
                }

                ExpensesList.Sort(delegate (ExpenseType x, ExpenseType y)
                {
                    return y.value.CompareTo(x.value);
                });
                
                OutputBlock.Inlines.Add(new Run("Your available moneys without vehicle repayments are R" + Math.Round(AvailableMonthlyMoneyWithoutCarRepayment, 2) + "\n"));
                OutputBlock.Inlines.Add(new Run(String.Join(Environment.NewLine, ExpensesList)));
            }
            else
            {
                Console.WriteLine("Wrong input");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string purpose;
            int years = 0, numberOfMonths = 0;
            double amount = 0;
            double interestRate = 0;

            purpose = purposetxt.Text;

            years = Convert.ToInt32(timetxt.Text);
            
            if(years <= 0)
            {
                MessageBox.Show("Invalid Time period entered!");
                timetxt.Focus();
            }
            else
            {
                numberOfMonths = years * 12;
            }

            amount = Convert.ToDouble(savingAmounttxt.Text);

            if(amount <= 0)
            {
                MessageBox.Show("Invalid Saving amount Entered");
            }

            interestRate = Convert.ToDouble(interestRatetxt.Text);
            interestRate = interestRate / 100;

            double monthlyPayments;

            double numerator = 1, denominator =1 ;

            numerator = amount * (interestRate / 12);

            denominator = Math.Pow((1 + interestRate / 12),numberOfMonths) -1;

            monthlyPayments = numerator / denominator;

            savingBlock.Inlines.Add(new Run("You need to deposit: R-" + Math.Round(monthlyPayments,2) + " per Month to reach:  R-" + amount + " in " + years + " years"));

            savingBlock.Inlines.Add(new Run("\nInterest Earned over the time : R-" + Math.Round((amount -(monthlyPayments * numberOfMonths)),2)));

        }

        private void rentProperty_Checked(object sender, RoutedEventArgs e)
        {
            if(rentProperty.IsChecked == true)
            {
                propertyPrice.Content = "Enter your Monthly Rent";
                propertyPrice.Visibility = Visibility.Visible;
                propertyPricetxt.Visibility = Visibility.Visible;
                depositLabel.Visibility = Visibility.Hidden;
                depositAmountTxt.Visibility = Visibility.Hidden;
                interestRate.Visibility = Visibility.Hidden;
                interestRateTxt.Visibility = Visibility.Hidden;
                monthsLabel.Visibility = Visibility.Hidden;
                propertyMonthstxt.Visibility = Visibility.Hidden;
            }
        }

        private void buyProperty_Checked(object sender, RoutedEventArgs e)
        {
            if (buyProperty.IsChecked == true)
            {
                propertyPrice.Visibility = Visibility.Visible;
                propertyPrice.Content = "Enter the property Price";

                propertyPrice.Visibility = Visibility.Visible;
                propertyPricetxt.Visibility = Visibility.Visible;
                depositLabel.Visibility = Visibility.Visible;
                depositAmountTxt.Visibility = Visibility.Visible;
                interestRate.Visibility = Visibility.Visible;
                interestRateTxt.Visibility = Visibility.Visible;
                monthsLabel.Visibility = Visibility.Visible;
                propertyMonthstxt.Visibility = Visibility.Visible;
            }
        }

        private void buyCar_Checked(object sender, RoutedEventArgs e)
        {
            if(buyCar.IsChecked == true)
            {
                carModel.Visibility = Visibility.Visible;
                carmodeltxt.Visibility = Visibility.Visible;
                carPriceLabel.Visibility = Visibility.Visible;
                carPricetxt1.Visibility = Visibility.Visible;
                depositcar.Visibility = Visibility.Visible;
                depositCartxt.Visibility = Visibility.Visible;
                interesteratelbl.Visibility = Visibility.Visible;
                carInteresteRatetxt.Visibility = Visibility.Visible;
                insurancelbl.Visibility = Visibility.Visible;
                insuranceAmounttxt.Visibility = Visibility.Visible;
            }
        }

        private void noCarButton_Checked(object sender, RoutedEventArgs e)
        {
            carModel.Visibility = Visibility.Hidden;
            carmodeltxt.Visibility = Visibility.Hidden;
            carPriceLabel.Visibility = Visibility.Hidden;
            carPricetxt1.Visibility = Visibility.Hidden;
            depositcar.Visibility = Visibility.Hidden;
            depositCartxt.Visibility = Visibility.Hidden;
            interesteratelbl.Visibility = Visibility.Hidden;
            carInteresteRatetxt.Visibility = Visibility.Hidden;
            insurancelbl.Visibility = Visibility.Hidden;
            insuranceAmounttxt.Visibility = Visibility.Hidden;
        }

       
    }
}
