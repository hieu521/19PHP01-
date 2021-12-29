using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helllooo
{
     class Program
    {
        
        static void main(string[] args)
        {
            Batch batch = new Batch("2021-2022");
            IO.PrintMenu();
            int inputmenu = MenuOptions.INIT;
            while (inputmenu != MenuOptions.EXIT)
            {
                inputmenu = IO.EnterMenuOptions();
                switch (inputmenu)
                {
                    case MenuOptions.PRINT_ALL_STUDENT:
                        IO.ToScreen(batch.PrintAllStudentInfo());
                        break;
                    case MenuOptions.ADD_STUDENT:
                        Batch.AddStudent(
                            IO.EnterStudentId(),
                            IO.EnterStudentName(),
                            IO.EnterStudentMajor(),
                            IO.EnterStudentAge(),
                            IO.EnterStudentClass(),
                            IO.EnterStudentGrade()
                            );
                        break;
                    case MenuOptions.EXIT:
                        return;
                    case MenuOptions.REMOVE_STUDENT:
                        IO.ShowMessage(batch.RemoveStudentByGrade(IO.EnterStudentGrade()));
                        break;
                    case MenuOptions.UPDATE_STUDENT:
                        IO.ShowMessage(
                            Batch.UpdateStudentById(

                            IO.EnterStudentId(),
                            IO.EnterStudentName(),
                            IO.EnterStudentMajor(),
                            IO.EnterStudentAge(),
                            IO.EnterStudentClass(),
                            IO.EnterStudentGrade()
                            )
                            );
                        break ;


                }
            }
        }

       
        

    }

}
