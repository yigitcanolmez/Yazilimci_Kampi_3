// See https://aka.ms/new-console-template for more information

using HWCamp;
Musteri musteri = new Musteri();
Customer customer = new Customer
{
    Id = 1,
    Name= "Yiğitcan",
    Surname = "Ölmez"
};

musteri.Ekle(customer);
musteri.Sil(customer.Id);
musteri.Update(customer.Id);



public class Musteri
{
    public void Ekle(Customer customer)
    {
        Console.WriteLine(customer.Id + " numaralı "+customer.Name + " " + customer.Surname + " isimli müşteri sisteme eklenmiştir.");
    }
    public void Sil(int id)
    {
        Console.WriteLine(id + " değerine sahip müşteri sistemden silinmiştir.");

    }
    public void Update(int id)
    {
        Console.WriteLine(id + " değerine sahip müşteri güncellenmiştir.");

    }
}