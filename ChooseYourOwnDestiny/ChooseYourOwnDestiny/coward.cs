using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnDestiny
{
    class coward
    {
        string response;
        public coward()
        {
            CowardEndingLeadUp();
        }
        private void CowardEndingLeadUp()
        {
            Console.WriteLine("In a panic you run out of the room. Mike was easily your favorite instructor *cough* ANDREW *cough*, and there he was, lying on the floor dead! Your head is throbbing with pain from last night's festivities and this is what you walk into, and the sun hasn't even crested the horizon fully. You call the police, and wait in the bathroom, having a panic attack, unable to come face to face with the gravity of the situation. \nThe police arrive at the scene and begin to intervew anyone who might have witnessed anything, yourself included\n\n");
            Console.WriteLine("The Police officer approaches you, you look at him nervously, you were never a troublemaker (yeah right), but at least you know you're not guilty./n The Officer says 'Hi, I'm Officer Larry Digby of the Milwaukee police department, may I ask you a few questions?\n");
            Console.WriteLine(" (Option 1) RUN: You opt to book it, not this time copper! (3/20 to escape)");
            Console.WriteLine(" (Option 2) Chat: Engage in dialogue with Officer Digby");
            Console.WriteLine("So are you going to flee in 'cowardice', again, or 'chat' with the nice officer");
            response = Console.ReadLine().ToLower();
            Console.ReadKey();
            CowardArc(response);

        }
        private void OfficerConversation()
        {

        }
        private void CowardArc(string response)
        {
            
            switch (response)
            {
                case "cowardice":
                    CowardLogic(CowardRoll());
                    break;
                case "chat":
                    break;
                default:
                    Console.WriteLine("That is an invalid response, please enter either 'cowardice' or 'chat'.");
                        CowardArc(response);
                    break;
            }
        }
        private int CowardRoll()
        {
            int rollCoward;
            Random rollDice = new Random();
            rollCoward = rollDice.Next(1, 21);
            return rollCoward;
        }
        private void CowardLogic(int diceRoll)
        {
            if (diceRoll % 6 == 0)
            {
                Console.WriteLine("  You successfully outrun the police whilst dodging hails of gun fire and drive off into the sunset; you win?");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("  Turns out you should have stuck to coding and not tried to be an athlete, don't run from the police, stupid.  You lose.");
                Console.ReadKey();
            }
        }

    }
}
