using CallCenterProject.Algorithms;
using CallCenterProject.DataStructures.LinkedList.SinglyLinkedList;
using CallCenterProject.DataStructures.Queue;
using CallCenterProject.Entity;
using System.Globalization;
using Timer = System.Windows.Forms.Timer;
using Type = CallCenterProject.Entity.Type;

namespace CallCenterProject
{
    public partial class Form1 : Form
    {
        Call item;
        private int _ticks;
        int callCount = 0;
        Type EndCallType;
        Call Individualcall1 = null;
        Call Individualcall2 = null;
        Call Commercialcall3 = null;
        Call Commercialcall4 = null;
        public Form1()
        {
            InitializeComponent();
            InitTimer();// zamanlayici calistirilir.
        }
        SinglyLinkedList<Call> _waitingcall = new();
        SinglyLinkedList<CustomerService> _customerServiceList = new();
        SinglyLinkedList<Call> EndCalls = new();
        private Timer timer1;

        public void InitTimer()
        {
            // zamanlayici
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 3000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LBListele.Items.Clear();
            LBBekleyen.Items.Clear();
            LBListele_1.Items.Clear();
            lBNowCall.Items.Clear();
            int count = 1;
            if(_waitingcall.Head != null)
            {
                // surekli bekleyen cagrilari gunceller.
                foreach (var item in _waitingcall)
                {
                    LBListele.Items.Add("Sira: " + count + "    Isim: " + item.Customer.FirstName + " " + item.Customer.LastName + "     Tip: " + item.CallType);
                    count++;
                }
                count = 1;
                foreach (var item in _waitingcall)
                {
                    LBBekleyen.Items.Add("Sira: " + count + "    Isim: " + item.Customer.FirstName + " " + item.Customer.LastName + "     Tip: " + item.CallType);
                    count++;
                }

            }
            foreach(var item in _customerServiceList)
            {
                string statu;
                if (item.Statu == true)
                    statu = "Uygun";
                else
                    statu = "Dolu";
                LBListele_1.Items.Add("Sira: " + item.Id + "    Isim: " + item.FirstName.ToString() + "     Tip: " + item.CustomerType + "     Durum  : " + statu);
            }
            // gerceklestirilen cagrilari listeler
            if(Individualcall1 != null)
                lBNowCall.Items.Add("Musteri Isim: " + Individualcall1.Customer.FirstName.ToString()+"    Temsilci Isim: " + Individualcall1.CustomerService.FirstName.ToString()+ "     Tip: " + Individualcall1.CallType);
            if (Individualcall2 != null)
                lBNowCall.Items.Add("Musteri Isim: " + Individualcall2.Customer.FirstName.ToString() + "    Temsilci Isim: " + Individualcall2.CustomerService.FirstName.ToString() + "     Tip: " + Individualcall2.CallType);
            if (Commercialcall3 != null)
                lBNowCall.Items.Add("Musteri Isim: " + Commercialcall3.Customer.FirstName.ToString() + "    Temsilci Isim: " + Commercialcall3.CustomerService.FirstName.ToString() + "     Tip: " + Commercialcall3.CallType);
            if (Commercialcall4 != null)
                lBNowCall.Items.Add("Musteri Isim: " + Commercialcall4.Customer.FirstName.ToString() + "    Temsilci Isim: " + Commercialcall4.CustomerService.FirstName.ToString() + "     Tip: " + Commercialcall4.CallType);
        }


        private void btnCall_Click(object sender, EventArgs e)
        {
            // cagri talebi olusturlur. Ve cagri sirasina duser.
            Customer customer = new();
            Call call = new();
            customer.FirstName = txtFirstName.Text;
            customer.LastName = txtLastName.Text;
            customer.TelNo = txtTelNo.Text;
            if (RBBireysel.Checked)  
                customer.CustomerType = Type.Individual;
            else 
                customer.CustomerType = Type.Commercial;
            call.Id = _waitingcall.Size + 1;
            call.CallType = customer.CustomerType;
            call.StartTime = DTPStart.Value;
            call.Customer = customer;


            _waitingcall.AddLast(call);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomerService _customerService1 = new();
            CustomerService _customerService2 = new();
            CustomerService _customerService3 = new();
            CustomerService _customerService4 = new();

            _customerService1.FirstName = "Musteri temsilcisi 1";
            _customerService2.FirstName = "Musteri temsilcisi 2";
            _customerService3.FirstName = "Musteri temsilcisi 3";
            _customerService4.FirstName = "Musteri temsilcisi 4";

            _customerService1.CustomerType = Type.Individual;
            _customerService2.CustomerType = Type.Individual;
            _customerService3.CustomerType = Type.Commercial;
            _customerService4.CustomerType = Type.Commercial;

            _customerService1.Id = 1;
            _customerService2.Id = 2;
            _customerService3.Id = 3;
            _customerService4.Id = 4;

            _customerServiceList.AddLast(_customerService1);
            _customerServiceList.AddLast(_customerService2);
            _customerServiceList.AddLast(_customerService3);
            _customerServiceList.AddLast(_customerService4);


            Customer customer1 = new();
            Call call1 = new();
            customer1.FirstName = "Kerem";
            customer1.LastName = "Bora";
            customer1.TelNo = "xxxxxxxxxx";
            customer1.CustomerType = Type.Individual;
            call1.Id =  1;
            call1.CallType = customer1.CustomerType;
            call1.ServiceNotes = "Urunde problem var.";
            call1.StartTime = DateTime.Now;
            call1.Customer = customer1;

            Customer customer2 = new();
            Call call2 = new();
            customer2.FirstName = "Nihat";
            customer2.LastName = "Bora";
            customer2.TelNo = "xxxxxxxxxx";
            customer2.CustomerType = Type.Commercial;
            call2.Id = 2;
            call2.CallType = customer2.CustomerType;
            call2.ServiceNotes = "urunu iade etmek istiyorum.";
            call2.StartTime = DateTime.Now;
            call2.Customer = customer2;

            Customer customer3 = new();
            Call call3 = new();
            customer3.FirstName = "Bora";
            customer3.LastName = "kerem";
            customer3.TelNo = "xxxxxxxxxx";
            customer3.CustomerType = Type.Commercial;
            call3.Id = 3;
            call3.CallType = customer3.CustomerType;
            call3.ServiceNotes = "Tavsiyeye ihtiyacim var.";
            call3.StartTime = DateTime.Now;
            call3.Customer = customer3;

            Customer customer4 = new();
            Call call4 = new();
            customer4.FirstName = "Bora";
            customer4.LastName = "Nihat";
            customer4.TelNo = "xxxxxxxxxx";
            customer4.CustomerType = Type.Individual;
            call4.Id = 4;
            call4.CallType = customer4.CustomerType;
            call4.ServiceNotes = "Hava durumu gunesli.";
            call4.StartTime = DateTime.Now;
            call4.Customer = customer4;

            Customer customer5 = new();
            Call call5 = new();
            customer5.FirstName = "Nihat Kerem";
            customer5.LastName = "Bora";
            customer5.TelNo = "xxxxxxxxxx";
            customer5.CustomerType = Type.Individual;
            call5.Id = 5;
            call5.CallType = customer5.CustomerType;
            call5.ServiceNotes = "Programiniz sorunlu calisiyor.";
            call5.StartTime = DateTime.Now;
            call5.Customer = customer5;

            _waitingcall.AddLast(call1);
            _waitingcall.AddLast(call2);
            _waitingcall.AddLast(call3);
            _waitingcall.AddLast(call4);
            _waitingcall.AddLast(call5);

        }

        private void btnStartCall_Click(object sender, EventArgs e)
        {
            
            if (LBBekleyen.SelectedIndex == -1)
            {
                foreach (var item in _waitingcall)
                {// siradan ekleme yapilir.

                    if (Individualcall1 == null && item.CallType == Type.Individual)
                    {
                        item.CustomerService = _customerServiceList.Head.Value;
                        Individualcall1 = item;
                        _customerServiceList.Head.Value.Statu = false;
                        _waitingcall.Remove(item);
                        break;
                    }

                    else if (Individualcall2 == null && item.CallType == Type.Individual)
                    {
                        item.CustomerService = _customerServiceList.Head.Next.Value;
                        Individualcall2 = item;
                        _customerServiceList.Head.Next.Value.Statu = false;
                        _waitingcall.Remove(item);
                        break;
                    }
                    else if (Commercialcall3 == null && item.CallType == Type.Commercial)
                    {
                        item.CustomerService = _customerServiceList.Head.Next.Next.Value;
                        Commercialcall3 = item;
                        _customerServiceList.Head.Next.Next.Value.Statu = false;
                        _waitingcall.Remove(item);
                        break;
                    }
                    else if (Commercialcall4 == null && item.CallType == Type.Commercial)
                    {
                        item.CustomerService = _customerServiceList.Head.Next.Next.Next.Value;
                        Commercialcall4 = item;
                        _customerServiceList.Head.Next.Next.Next.Value.Statu = false;
                        _waitingcall.Remove(item);
                        break;
                    }
                }
            }
            else
            {
                // listboxtan secilen nesnenin indexi alinir ve listte nesne bulunur.Ve ekleme Yapilir.
                int index = LBBekleyen.SelectedIndex;
                int count = 0;
                var temp = _waitingcall.Head;
                while(count < index)
                {
                    temp = temp.Next;
                    count++;
                }
                var item = temp.Value;

                    if (Individualcall1 == null && item.CallType == Type.Individual)
                {
                    item.CustomerService = _customerServiceList.Head.Value;
                    Individualcall1 = item;
                    _customerServiceList.Head.Value.Statu = false;
                    _waitingcall.Remove(item);
                   
                }

                else if (Individualcall2 == null && item.CallType == Type.Individual)
                {
                    item.CustomerService = _customerServiceList.Head.Next.Value;
                    Individualcall2 = item;
                    _customerServiceList.Head.Next.Value.Statu = false;
                    _waitingcall.Remove(item);
                    
                }
                else if (Commercialcall3 == null && item.CallType == Type.Commercial)
                {
                    item.CustomerService = _customerServiceList.Head.Next.Next.Value;
                    Commercialcall3 = item;
                    _customerServiceList.Head.Next.Next.Value.Statu = false;
                    _waitingcall.Remove(item);
                    
                }
                else if (Commercialcall4 == null && item.CallType == Type.Commercial)
                {
                    item.CustomerService = _customerServiceList.Head.Next.Next.Next.Value;
                    Commercialcall4 = item;
                    _customerServiceList.Head.Next.Next.Next.Value.Statu = false;
                    _waitingcall.Remove(item);
                }
            }


        }


       

        private void btnEndCall_1_Click(object sender, EventArgs e)
        {
            // gerceklesen cagiriyi bitirir ve biten cagrilar listesine ekler.
            Individualcall1.EndTime = DateTime.Now;
            Individualcall1.ServiceNotes = txtNot.Text;
            EndCalls.AddLast(Individualcall1);
            EndCallType = Individualcall1.CallType;
            Individualcall1 = null;
            callCount--;
            _customerServiceList.Head.Value.Statu = true;
            
        }

        private void btnEndCall_2_Click(object sender, EventArgs e)
        {
            Individualcall2.EndTime = DateTime.Now;
            Individualcall2.ServiceNotes = txtNot.Text;
            EndCalls.AddLast(Individualcall2);
            EndCallType = Individualcall2.CallType;
            Individualcall2 = null;
            callCount--;
            _customerServiceList.Head.Next.Value.Statu = true;
        }

        private void btnEndCall_3_Click(object sender, EventArgs e)
        {
            Commercialcall3.EndTime = DateTime.Now;
            Commercialcall3.ServiceNotes = txtNot.Text;
            EndCalls.AddLast(Commercialcall3);
            EndCallType = Commercialcall3.CallType;
            Commercialcall3 = null;
            callCount--;
            _customerServiceList.Head.Next.Next.Value.Statu = true;
        }

        private void btnEndCall_4_Click(object sender, EventArgs e)
        {
           
            Commercialcall4.EndTime = DateTime.Now;
            Commercialcall4.ServiceNotes = txtNot.Text;
            EndCalls.AddLast(Commercialcall4);
            EndCallType = Commercialcall4.CallType;
            Commercialcall4 = null;
            callCount--;
            _customerServiceList.Head.Next.Next.Next.Value.Statu = true;
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            // girilen metni iciren nesneri bulup yazdirir.
            LBAramaSonucu.Items.Clear();
            string metin = txtNotAra.Text;
            string temp = metin;
            txtNotAra.Text = " ";
            var end = EndCalls.Clone();
            Search search = new();
            var list = search.LinearSearch(end, metin);
            LBAramaSonucu.Items.Add("Aranan Kelime: " + temp);
            LBAramaSonucu.Items.Add("           ");
            foreach(var item in list)
                LBAramaSonucu.Items.Add("Isim: " + item.Customer.FirstName.ToString() + "    Tip: " + item.CallType + "   Not: "+ item.ServiceNotes);
        }

    
        private void btnRapor_Click(object sender, EventArgs e)
        {
            // rapor yazdirir.
            var dateCounts = EndCalls.Clone().GroupBy(m => m.StartTime.ToString("yyyyMMdd"))
                .Select(m => new TarihRapor
                {
                    Date = DateTime.ParseExact(m.Key, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None),
                    Count = m.Count()
                }).ToList();
            Sort sort = new();
            sort.Insertionsort(dateCounts, (e1, e2) => e1.Count > e2.Count);
            foreach(var date in dateCounts) 
            {
                LBRapor.Items.Add("Tarih:  "+ date.Date + "     Cagri Sayisi:  "+ date.Count);
            }

        }

        
    }
}