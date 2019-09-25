    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace Inclass_OOPs_Practice
    {
        class Person
        {
            public static string salutationMr = "Mr";
            public static string salutationMs = "Ms";
            public static string defaultlastName = "NLN";
            public string firstName;
            public string lastName;
            public string salutation;
            public Person()
            {
                firstName = "";
                lastName = defaultlastName;
                salutation = salutationMs;
            }
            public Person(string salutation1, string fName, string lName)
            {
                salutation = salutation1;// needs refinement     
                firstName = fName;
                lastName = lName;
            }

        }
    }
