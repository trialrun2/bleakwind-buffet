using BleakwindBuffet.Data;
using RoundRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace PointOfSale
{
    public class RegisterViewModel : INotifyPropertyChanged
    { 
        public event PropertyChangedEventHandler PropertyChanged;

        public void PropChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private Order currentOrder;

        public RegisterViewModel(Order order)
        {
            currentOrder = order;
            
        }

        public int RegisterHundreds
        {
            get => CashDrawer.Hundreds;
            set
            {
                CashDrawer.Hundreds = value;
                PropChanged("RegisterHundreds");
            }
        }

        public int RegisterFifties
        {
            get => CashDrawer.Fifties;
            set
            {
                CashDrawer.Fifties = value;
                PropChanged("RegisterFifties");
            }
        }

        public int RegisterTwenties
        {
            get => CashDrawer.Twenties;
            set
            {
                CashDrawer.Twenties = value;
                PropChanged("RegisterTwenties");
            }
        }

        public int RegisterTens
        {
            get => CashDrawer.Tens;
            set
            {
                CashDrawer.Tens = value;
                PropChanged("RegisterTens");
            }
        }

        public int RegisterFives
        {
            get => CashDrawer.Fives;
            set
            {
                CashDrawer.Fives = value;
                PropChanged("RegisterFives");
            }
        }

        public int RegisterTwos
        {
            get => CashDrawer.Twos;
            set
            {
                CashDrawer.Twos = value;
                PropChanged("RegisterTwos");
            }
        }

        public int RegisterOnes
        {
            get => CashDrawer.Ones;
            set
            {
                CashDrawer.Ones = value;
                PropChanged("RegisterOnes");
            }
        }

        public int RegisterDollars
        {
            get => CashDrawer.Dollars;
            set
            {
                CashDrawer.Dollars = value;
                PropChanged("RegisterDollars");
            }
        }

        public int RegisterHalfDollars
        {
            get => CashDrawer.HalfDollars;
            set
            {
                CashDrawer.HalfDollars = value;
                PropChanged("RegisterHalfDollars");
            }
        }

        public int RegisterQuarters
        {
            get => CashDrawer.Quarters;
            set
            {
                CashDrawer.Quarters = value;
                PropChanged("RegisterQuarters");
            }
        }

        public int RegisterDimes
        {
            get => CashDrawer.Dimes;
            set
            {
                CashDrawer.Dimes = value;
                PropChanged("RegisterDimes");
            }
        }

        public int RegisterNickels
        {
            get => CashDrawer.Nickels;
            set
            {
                CashDrawer.Nickels = value;
                PropChanged("RegisterNickels");
            }
        }

        public int RegisterPennies
        {
            get => CashDrawer.Pennies;
            set
            {
                CashDrawer.Pennies = value;
                PropChanged("RegisterPennies");
            }
        }

        private int customerHundreds = 0;
        public int CustomerHundreds
        {
            get => customerHundreds;
            set
            {
                customerHundreds = value;
                PropChanged("CustomerHundreds");
            }
        }

        private int customerFifties = 0;
        public int CustomerFifties
        {
            get => customerFifties;
            set
            {
                customerFifties = value;
                PropChanged("CustomerFifties");
            }
        }

        private int customerTwenties = 0;
        public int CustomerTwenties
        {
            get => customerTwenties;
            set
            {
                customerTwenties = value;
                PropChanged("CustomerTwenties");
            }
        }

        private int customerTens = 0;
        public int CustomerTens
        {
            get => customerTens;
            set
            {
                customerTens = value;
                PropChanged("CustomerTens");
            }
        }

        private int customerFives = 0;
        public int CustomerFives
        {
            get => customerFives;
            set
            {
                customerFives = value;
                PropChanged("CustomerFives");
            }
        }

        private int customerTwos = 0;
        public int CustomerTwos
        {
            get => customerTwos;
            set
            {
                customerTwos = value;
                PropChanged("CustomerTwos");
            }
        }

        private int customerOnes = 0;
        public int CustomerOnes
        {
            get => customerOnes;
            set
            {
                customerOnes = value;
                PropChanged("CustomerOnes");
            }
        }

        private int customerDollars = 0;
        public int CustomerDollars
        {
            get => customerDollars;
            set
            {
                customerDollars = value;
                PropChanged("CustomerDollars");
            }
        }

        private int customerHalfDollars = 0;
        public int CustomerHalfDollars
        {
            get => customerHalfDollars;
            set
            {
                customerHalfDollars = value;
                PropChanged("CustomerHalfDollars");
            }
        }

        private int customerQuarters = 0;
        public int CustomerQuarters
        {
            get => customerQuarters;
            set
            {
                customerQuarters = value;
                PropChanged("CustomerQuarters");
            }
        }

        private int customerDimes = 0;
        public int CustomerDimes
        {
            get => customerDimes;
            set
            {
                customerDimes = value;
                PropChanged("CustomerDimes");
            }
        }

        private int customerNickels = 0;
        public int CustomerNickels
        {
            get => customerNickels;
            set
            {
                customerNickels = value;
                PropChanged("CustomerNickels");
            }
        }

        private int customerPennies = 0;
        public int CustomerPennies
        {
            get => customerPennies;
            set
            {
                customerPennies = value;
                PropChanged("CustomerPennies");
            }
        }

        private int customerChangeHundreds = 0;
        public int CustomerChangeHundreds
        {
            get => customerChangeHundreds;
            set
            {
                customerChangeHundreds = value;
                PropChanged("CustomerChangeHundreds");
            }
        }

        private int customerChangeFifties = 0;
        public int CustomerChangeFifties
        {
            get => customerChangeFifties;
            set
            {
                customerChangeFifties = value;
                PropChanged("CustomerChangeFifties");
            }
        }

        private int customerChangeTwenties = 0;
        public int CustomerChangeTwenties
        {
            get => customerChangeTwenties;
            set
            {
                customerChangeTwenties = value;
                PropChanged("CustomerChangeTwenties");
            }
        }

        private int customerChangeTens = 0;
        public int CustomerChangeTens
        {
            get => customerChangeTens;
            set
            {
                customerChangeTens = value;
                PropChanged("CustomerChangeTens");
            }
        }

        private int customerChangeFives = 0;
        public int CustomerChangeFives
        {
            get => customerChangeFives;
            set
            {
                customerChangeFives = value;
                PropChanged("CustomerChangeFives");
            }
        }

        private int customerChangeTwos = 0;
        public int CustomerChangeTwos
        {
            get => customerChangeTwos;
            set
            {
                customerChangeTwos = value;
                PropChanged("CustomerChangeTwos");
            }
        }

        private int customerChangeOnes = 0;
        public int CustomerChangeOnes
        {
            get => customerChangeOnes;
            set
            {
                customerChangeOnes = value;
                PropChanged("CustomerChangeOnes");
            }
        }

        private int customerChangeDollars = 0;
        public int CustomerChangeDollars
        {
            get => customerChangeDollars;
            set
            {
                customerChangeDollars = value;
                PropChanged("CustomerChangeDollars");
            }
        }

        private int customerChangeHalfDollars = 0;
        public int CustomerChangeHalfDollars
        {
            get => customerChangeHalfDollars;
            set
            {
                customerChangeHalfDollars = value;
                PropChanged("CustomerHalfDollars");
            }
        }

        private int customerChangeQuarters = 0;
        public int CustomerChangeQuarters
        {
            get => customerChangeQuarters;
            set
            {
                customerChangeQuarters = value;
                PropChanged("CustomerChangeQuarters");
            }
        }

        private int customerChangeDimes = 0;
        public int CustomerChangeDimes
        {
            get => customerChangeDimes;
            set
            {
                customerChangeDimes = value;
                PropChanged("CustomerChangeDimes");
            }
        }

        private int customerChangeNickels = 0;
        public int CustomerChangeNickels
        {
            get => customerChangeNickels;
            set
            {
                customerChangeNickels = value;
                PropChanged("CustomerChangeNickels");
            }
        }

        private int customerChangePennies = 0;
        public int CustomerChangePennies
        {
            get => customerChangePennies;
            set
            {
                customerChangePennies = value;
                PropChanged("CustomerChangePennies");
            }
        }

        private double totalPaid = 0;
        public double TotalPaid
        {
            get
            {
                totalPaid = (CustomerPennies * .01) + (customerNickels * .05) + (customerDimes * .1) + (CustomerQuarters * .25) + (CustomerHalfDollars * .5) +
                    CustomerDollars + CustomerOnes + (CustomerTwos * 2) + (CustomerFives * 5) + (CustomerTens * 10) + (CustomerTwenties * 20) + (CustomerFifties * 50)
                    + (CustomerHundreds * 100);
                return totalPaid;
            }
        }

        private double amountDue = 0;
        public double AmountDue
        {
            get
            {
                amountDue = currentOrder.Total - TotalPaid;
                if(amountDue < 0)
                {
                    ChangeDue = amountDue * -1;
                    amountDue = 0;
                }
                return amountDue;
            }
        }

        private double changeDue = 0;
        public double ChangeDue
        {
            get => changeDue;
            set
            {
                changeDue = value;
                SetChangeAmounts();
            }
        }

        private void SetChangeAmounts()
        {
            CustomerChangeHundreds = (int)ChangeDue % 100;
            ChangeDue = ChangeDue - (CustomerChangeHundreds * 100);
            CustomerChangeFifties = (int)ChangeDue % 50;
            ChangeDue = ChangeDue - (CustomerChangeFifties * 50);
            CustomerChangeTwenties = (int)ChangeDue % 20;
            ChangeDue = ChangeDue - (CustomerChangeTwenties * 100);
            CustomerChangeTens = (int)ChangeDue % 10;
            ChangeDue = ChangeDue - (CustomerChangeTens * 10);
            CustomerChangeFives = (int)ChangeDue % 5;
            ChangeDue = ChangeDue - (CustomerChangeFives * 5);
            CustomerChangeTwos = (int)ChangeDue % 2;
            ChangeDue = ChangeDue - (CustomerChangeTwos * 2);
            CustomerChangeOnes = (int)ChangeDue % 1;
            ChangeDue = ChangeDue - CustomerChangeOnes;
            CustomerChangeDollars = (int)ChangeDue % 1;
            ChangeDue = ChangeDue - CustomerDollars;
            CustomerChangeHalfDollars = (int)ChangeDue % (1 / 2);
            ChangeDue = ChangeDue - (CustomerChangeHalfDollars * .5);
            CustomerChangeQuarters = (int)ChangeDue % (1 / 4);
            ChangeDue = ChangeDue - (CustomerChangeQuarters * .25);
            CustomerChangeDimes = (int)ChangeDue % (1 / 10);
            ChangeDue = ChangeDue - (CustomerChangeDimes * .1);
            CustomerChangeNickels = (int)ChangeDue % (1 / 20);
            ChangeDue = ChangeDue - (CustomerChangeNickels * .05);
            CustomerChangePennies = (int)ChangeDue % (1 / 100);
            ChangeDue = ChangeDue - (CustomerChangePennies * .01);
        }

        public string PayWithCard()
        {
            string message = "Error Reading Card. Please try agian or use another payment method";
            if (CardTransactionResult.Approved == CardReader.RunCard(AmountDue))
            {
                message = "Card Approved, printing receipt";
            }
            if (CardTransactionResult.Declined == CardReader.RunCard(AmountDue))
            {
                message = "Card Declined. Please try again or try another payment method";
            }
            if (CardTransactionResult.IncorrectPin == CardReader.RunCard(AmountDue))
            {
                message = "Incorrect Pin. Please try agian or use another payment method";
            }
            if (CardTransactionResult.InsufficientFunds == CardReader.RunCard(AmountDue))
            {
                message = "Insufficient funds. Please try another payment method";
            }
            if (CardTransactionResult.ReadError == CardReader.RunCard(AmountDue))
            {
                message = "Error Reading Card. Please try agian or use another payment method";
            }
            return message;
        }

        public void FinalizePayment()
        {
            CashDrawer.OpenDrawer();
            RegisterHundreds = RegisterHundreds + CustomerHundreds - CustomerChangeHundreds;
            RegisterFifties = RegisterFifties + CustomerFifties - CustomerChangeFifties;
            RegisterTwenties = RegisterTwenties + CustomerTwenties - CustomerChangeTwenties;
            RegisterTens = RegisterTens + CustomerTens - CustomerChangeTens;
            RegisterFives = RegisterFives + CustomerFives - CustomerChangeFives;
            RegisterTwos = RegisterTwos + CustomerTwos - CustomerChangeTwos;
            RegisterOnes = RegisterOnes + CustomerOnes - CustomerChangeOnes;
            RegisterDollars = RegisterDollars + CustomerDollars - CustomerChangeDollars;
            RegisterHalfDollars = RegisterHalfDollars + CustomerHalfDollars - CustomerChangeHalfDollars;
            RegisterQuarters = RegisterQuarters + CustomerQuarters - CustomerChangeQuarters;
            RegisterDimes = RegisterDimes + CustomerDimes - CustomerChangeDimes;
            RegisterNickels = RegisterNickels + CustomerNickels - CustomerChangeNickels;
            RegisterPennies = RegisterPennies + CustomerPennies - CustomerChangePennies;
        }

    }
}
