namespace CompanyInfo
{
    using System;

    class PrintCompanyInfo
    {
        static void Main()
        {
            string companyName = Console.ReadLine();
            string address = Console.ReadLine();
            string telephone = Console.ReadLine();
            string fax = Console.ReadLine();
            string webSite = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            string managerAge = Console.ReadLine();
            string managerPhone = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}", address);
            Console.WriteLine("Tel. {0}", telephone);
            Console.WriteLine("Fax: {0}", fax != string.Empty ? fax : "(no fax)");
            Console.WriteLine("Web site: {0}", webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName,
                                                            managerAge, managerPhone);
        }
    }
}
