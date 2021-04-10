using System;

namespace EngCourse
{
    partial class Program
    {
        public class tuPackage{
            string v;
            string x;
            void tampilkanPaket(){
                Console.Write("1. English for Kids");
                Console.Write("2. English for Student");
                Console.Write("3. English for Adults");
                Console.Write("4. Conversation for Teens");
                Console.Write("5. Bussiness English");
                Console.Write("6. TOEFL Test");
                Console.Write("7. IETLS Test");
                Console.Write("8. TOEIC Test");

                int pilihan=Convert.ToInt32(v);
                if(pilihan==1){
                    Console.WriteLine("You'll join the English for Kids' Class");
                }
                if(pilihan==2){
                    Console.WriteLine("You'll join the English for Students' Class");
                }
                if(pilihan==3){
                    Console.WriteLine("You'll join the English for Adults' Class");
                }
                if(pilihan==4){
                    Console.WriteLine("You'll join the Conversations for Teens' Class");
                }
                if(pilihan==5){
                    Console.WriteLine("You'll join the Bussiness English's Class");
                }
                if(pilihan==6){
                    Console.WriteLine("You'll join the TOEFL Test's Class");
                }
                if(pilihan==7){
                    Console.WriteLine("You'll join the IELTS Test's Class");
                }
                if(pilihan==8){
                    Console.WriteLine("You'll join the TOEIC Test's Class");
                }
                else{
                    Console.WriteLine("Please follow the instruction");
                }

        }
            void tampilkanHari(){
                Console.Write("A. Monday dan Thursday");
                Console.Write("B. Tuesday dan Friday");
                Console.Write("C. Wednesday dan Saturday");

                if(x=="A"){
                    Console.WriteLine("Okay! Don't forget to join the class every Monday and Thursday! ");
                }
                if(x=="B"){
                    Console.WriteLine("Okay! Don't forget to join the class every Tuesday and Friday! ");
                }
                if(x=="C"){
                    Console.WriteLine("Okay! Don't forget to join the class every Wednesday and Saturday! ");
                }
            }
            }

    }
}

 