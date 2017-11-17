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
            Console.WriteLine("The Police officer approaches you, you look at him nervously, you were never a troublemaker (yeah right), but\n at least you know you're not guilty. The Officer says 'Hi, I'm Officer Larry Digby of the Milwaukee police department, may I ask you a few questions?\n");
            Console.WriteLine(" (Option 1) RUN: You opt to book it, not this time copper! (3/20 to escape)");
            Console.WriteLine(" (Option 2) Chat: Engage in dialogue with Officer Digby. (4/9 to survive prosecution 5/9 to be wrongfully convicted by a broken justice system.)");
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
                    PoliceDialogue();
                    break;
                default:
                    Console.WriteLine("That is an invalid response, please enter either 'cowardice' or 'chat'.");
                    response = Console.ReadLine();
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
        private void PoliceDialogue()
        {
            Console.WriteLine("The Officer explains to you that the current evidence leads to you as the prime suspect.  How could this be? You might not be a saint, but you've never been malicious, nor violent.  You protest and try to calmly (as calmly as possible given the impossible scenario) explain your innocence, how you weren't even the person on the scene. Digby says 'Unfortunately son, we can't just take your word for it, we need to bring you for further questioning.' The police officer escorts you to the back of a squad car. Please type 'roll' to see the results of your interrogation.");
            string interrogationResult = Console.ReadLine();
            if (interrogationResult == "roll")
            {
                InterrogationOutcomes(InterrogationRoll());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("By not typing roll, you lose, deal with it.");
                Console.ReadKey();
            }
            
        }
        private int InterrogationRoll()
        {
            Random rollForFreedom = new Random();
            int interrogationRoll = rollForFreedom.Next(1, 10);
            return interrogationRoll;
        }
        private void InterrogationOutcomes (int interrogationRoll)
        {
            if (interrogationRoll % 2 == 0)
            {
                Console.WriteLine("It would appear fortune has smiled on you for once in this unfortunate day, now if only this headache would go away, the interrogation lights did not help. You win!");
                Console.ReadKey();
            }else
            {
                Console.WriteLine(" 'Someone framed me!', you proclaim, as they drag you kicking and screaming to a cell to await your fate.  Things are not looking good for you as the evidence seems to have piled against you. In a few short days, you're convicted, innocent, but only in your own eyes, sadly. You lose.");
                Console.ReadKey();
            }
        }
    }
}
