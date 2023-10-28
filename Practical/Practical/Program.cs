using Practical;
using Practical.Helpers.Extensions;
using System.Runtime.CompilerServices;


#region Last time Homework
//Console.WriteLine("Add an email: ");
//string email = Console.ReadLine();

//var result = email.CheckEmail();


//if (result == false)
//{
//    Console.WriteLine("You have more than 1 or no @ sign");
//}
//else
//{
//    Console.WriteLine("You have written the email successfully");
//}



//Console.WriteLine("Add your email:");
//string email = Console.ReadLine();

//var result = email.CheckTrimEmail(@" ");

//if(result == false)
//{
//    Console.WriteLine("No space");
//}
//else
//{
//    Console.WriteLine("Yes space");
//}


//Person person = new();
//person.Id = 1;
//person.Name = "Omar";
//person.Surname = "Alasgarli";

//Console.WriteLine(person.GetFullName());

//int[] arr = { 1, 2, 3, 4, 5 };
//var result = arr.GetMultiplicationOfArray();

//Console.WriteLine(result);

#endregion


//IntList list = new IntList();

//list.Add(1);
//list.Add(2);
//list.Add(3);

//list.GetAll();

//StringList list1 = new StringList();

//list1.Add("a");
//list1.Add("b");
//list1.Add("c");

//list1.GetAll();

//PersonList personList = new PersonList();

//personList.Add(new Person { Id = 1, Name = "a", Surname = "b" });
//personList.Add(new Person { Id = 2, Name = "c", Surname = "d" });
//personList.Add(new Person { Id = 3, Name = "e", Surname = "f" });

//personList.GetAll();


//DataList<int> datas = new();

//datas.Add(1);
//datas.Add(2);

//datas.GetAll();


//DataList<string> stringList = new();

//stringList.Add("1");
//stringList.Add("lets");

//stringList.GetAll();

//DataList<Person> students = new();

//students.Add(new Person { Id = 1, Name = "a", Surname = "b" });
//students.Add(new Person { Id = 2, Name = "c", Surname = "d" });
//students.Add(new Person { Id = 3, Name = "e", Surname = "f" });

//var res = students.GetAll();

//foreach (var item in res)
//{
//    Console.WriteLine($"{item.Name}");
//}


//Repository<string> repo1 = new Repository<string>();

string paymentType = "Cash";

static void CheckPaymentType(string type)
{
    switch (type)
    {
        case nameof(PaymentType.Card):
            Console.WriteLine("With Card");
            break;
        case nameof(PaymentType.Cash):
            Console.WriteLine("With Cash");
            break;
        default:
            Console.WriteLine("No payment");
            break;
    }



    //if (type == PaymentType.Card.ToString())
    //{
    //    Console.WriteLine("With card");
    //}
    //else if(type == PaymentType.Cash.ToString())
    //{
    //    Console.WriteLine("With cash");
    //}
    //else { Console.WriteLine("No payment"); }

}

CheckPaymentType(paymentType);


