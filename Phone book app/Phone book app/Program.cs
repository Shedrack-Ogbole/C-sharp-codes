Dictionary<string, string> phonebook = new Dictionary<string, string>();

while (true)
{
   
    Console.WriteLine("What would you like to do?...... SAVE,VIEW,UPDATE,DELETE");
    string op = Console.ReadLine();
    if (op == "SAVE")
    {
        Console.WriteLine("Enter contact name"); 
        string name = Console.ReadLine();
        Console.WriteLine("Enter contact number");
        string number = Console.ReadLine();

        phonebook.Add(name, number);

        Console.WriteLine($"{number} successfully save");

    }
    else if (op == "VIEW")
    {
        Console.WriteLine("Enter contact name to view number");
        string contactname = Console.ReadLine();
      if(phonebook.ContainsKey(contactname))
        {
            Console.WriteLine(phonebook[contactname]);
        }
        else
        {
            Console.WriteLine("contact does not exist");

        }
    }
    else if (op == "UPDATE")
    {
        Console.WriteLine("Enter contact name to update");
        string updatename = Console.ReadLine();
        Console.WriteLine("Enter new number to update");
        string updatenumber = Console.ReadLine();
        phonebook[updatename] = updatenumber;
        Console.WriteLine(phonebook[updatename]);
        Console.WriteLine("Contact successfully updated");
      
    }
    else if (op == "DELETE")
    {
        Console.WriteLine("Enter contact name to delete");
        string delcontact = Console.ReadLine();
        phonebook.Remove(delcontact);
        if (phonebook.ContainsKey(delcontact))
        {
            Console.WriteLine("Number successfull deleted");
        }
        else
        {
            Console.WriteLine("Number does not exist");
        }

    }
    else
    {
        Console.WriteLine("INVALIDE COMMAND");
    }
}
//    Dictionary<string, string> phonebook = new Dictionary<string, string>();
//    while (true)
//    {
//        Console.WriteLine("what would u like to do save, view, update, delete");
//        string op = Console.ReadLine();

//        if (op == "save")
//        {
//            Console.WriteLine("u entered save");
//            Console.WriteLine("enter contact name");
//            string name = Console.ReadLine();

//            Console.WriteLine("enter contact number");
//            string number = Console.ReadLine();

//            phonebook.Add(name, number);
//            Console.WriteLine("" + name + " sucessfully saved");
//        }


//        else if (op == "view")
//        {

//            Console.WriteLine("u entered view");
//            Console.WriteLine("enter contact name to view");
//            string contactname = Console.ReadLine();
//            if (phonebook.ContainsKey(contactname))
//            {
//                Console.WriteLine(phonebook[contactname]);
//            }
//            else
//            {
//                Console.WriteLine("contact does not exist");
//            }

//        }


//        else if (op == "update")
//        {
//            Console.WriteLine("u entered update");
//            Console.WriteLine("enter contact name to update");
//            string name = Console.ReadLine();
//            Console.WriteLine("enter new number to update");
//            string number = Console.ReadLine();
//            phonebook[name] = number;
//            Console.WriteLine(phonebook[name]);
//            Console.WriteLine("number updated sucessfully");


//            /* Console.WriteLine(phonebook[update]);
//            //myDictionary[myKey] = myNewValue;
//            phonebook[update] = newnum;
//            Console.WriteLine("phonenumber updated successfully");
//            Console.WriteLine(phonebook[newnum]);*/
//        }


//        else if (op == "delete")
//        {
//            Console.WriteLine("u entered delete");
//            Console.WriteLine("enter contact name to delete");
//            string name = Console.ReadLine();
//            phonebook.Remove(name);
//            Console.WriteLine("number deleted sucessfully");
//        }

//        else
//        {
//            Console.WriteLine("invalid command");
//        }
//    }

