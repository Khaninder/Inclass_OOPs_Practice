using System;
using System.Collections.Generic;
using System.Text;

namespace Inclass_OOPs_Practice
{
    class RegisteredVoter : Person
    {
        public static string state;
        public static int age;
        public static string voterID;

        public RegisteredVoter(): base()
        {
            state = "";
            age = 0;
            voterID= "";
        }

        public RegisteredVoter(string vState,int vAge,string VoterID) : base()
        {
            state = vState;
            age = vAge;
            voterID = VoterID;

        }

    }
}
