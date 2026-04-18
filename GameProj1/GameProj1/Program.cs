using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GameProj1
{

    internal class Program
    {
        static void Main()
        {
            //Game setup
            Console.Title = "Coco";
            string Okay;
            string Alright;
            //Intro
            Console.WriteLine("You are a cat");
            Okay = Console.ReadLine();
            Console.WriteLine("Your name is Sugeknight from now on");
            Alright = Console.ReadLine();
            Console.WriteLine("Goodmorning Sugeknight, in front of you are two doors");

            StartGame();

        }

        static void StartGame()
        {
            Console.WriteLine("Do you wish to head into (1) The Bathroom or (2) The Kitchen?");
            string choice = Console.ReadLine();

            //Branching
            switch (choice)
            {
                case "1":
                    BathroomPath();
                    break;
                case "2":
                    KitchenPath();
                    break;
                default:
                    Console.WriteLine("Invalid choice, you went back to sleep and ended up dying. Cause of death FOMO..rip");
                    break;
            }

        }

        //If player chooses bathroom
        static void BathroomPath()
        {
            Console.WriteLine("You enter the bathroom and see a shower, you don't know why you have it since the shower you take is the human equivalent of dragging a wet rag made of spit all over yourself but all you do for now is observe yourself in the mirror.");
            Console.WriteLine("Do you wish to (1) Go Outside with the confidence of a thousand men and an empty stomach or (2) Go to The Kitchen and eat a breakfast of champions");
            string choice2 = Console.ReadLine();
            switch (choice2)
            {
                case "1":
                    ThousandMenPath();
                    break;
                case "2":
                    KitchenPath();
                    break;
            }
        }

        //First choice for Bathroom Path
        static void ThousandMenPath()
        {
            Console.WriteLine("You decided the best choice as a cat, who has nearly an infinite stomach, to go out into the world with nothing to fill your stomach, you died due to delusions of food leading you to fall off a cliff");
        }

        //Kitchen Path(Finallyyy)
        static void KitchenPath()
        {
            string Hooray;
            string CatClub;
            string Apparently;


            Console.WriteLine("You see the kitchen and make yourself a hearty, heavily processed tuna, Hooray chemicles!");
            Hooray = Console.ReadLine();
            Console.WriteLine("After the amazing breakfast you remember the night before, you were at the CatClub and you met a beautiful Siamese cat. Issue is you don't remember her name.");
            CatClub = Console.ReadLine();
            Console.WriteLine("You decide the best thing to shake up your bachelor lifestlye is to seek out this potential partner who you were so compatible with last night Apparently.");
            Apparently = Console.ReadLine();
            Console.WriteLine("Don't you want to tidy yourself up a bit before heading out? (1)Yes (2)No");
            string choice3 = Console.ReadLine();

            switch (choice3)
            {
                case "1":
                    Yespath();
                    break;
                case "2":
                    Nopath();
                    break;
            }
            //End of Kitchen scene and now onto the split where you can get one of two endings
        }

        static void Yespath()
        {
            string Yes;
            string CatClub;
            string Hello;
            string What;
            string Felines;

            Console.WriteLine("You go to put on your sunday best. Take a bit more time to groom, and wear your nicest(and arguably most expensive)cologne before heading out");
            CatClub = Console.ReadLine();
            Console.WriteLine("Driving off in your car you make haste to get to the club from the night before. The club is dull in the daytime compared to it's view at night but you pay no mind to those details as you make your way inside and greet the evening bartender.");
            Hello = Console.ReadLine();
            Console.WriteLine("What's up Suge? You really went all out last night didn't you?");
            What = Console.ReadLine();
            Console.WriteLine("Oh yeah no you went ham man, like it was The Hangover level crazy I even remember seeing a few felines on you last night,");
            Felines = Console.ReadLine();
            Console.WriteLine("Yeah there were a couple, what you here looking to see if I happen to know any of them?");
            Yes = Console.ReadLine();
            Console.WriteLine("Oh..well I mean yeah I do I didn't actually expect a bachelor like you would've wanted any of em but alright who's information do you want?");
            Console.WriteLine("(1) Scarlett (2) Hazel (3) Coco");

            string Choice4 = Console.ReadLine();

            switch (Choice4)
            {
                case "1":
                    ScarlettPath();
                    break;
                case "2":
                    HazelPath();
                    break;
                case "3":
                    CocoPath();
                    break;
            }

        }
            static void ScarlettPath()
            {
                string Hello;
                string SugeKnight;
                string Scarlett;
                string Ah;

                Console.WriteLine("The phone rings, several rings pass and you think no one will pick up but then the phone is picked up. You hear a feminine voice on the other end, it is deeper sounding than average but it sounded smooth as well");
                Hello= Console.ReadLine();
                Console.WriteLine("Hello? Who is this?");
                SugeKnight = Console.ReadLine();
                Console.WriteLine("Oh... hey Sugeknight, I know you probably don't remember me but we met at the club last night, I'm Scarlett");
                Scarlett = Console.ReadLine();
                Console.WriteLine("Yeah we spent some time together at the booth, you bought me quite a few drinks and we had a good time but if you are going to ask what I think you are going to ask, no I'm, not interested in going out with anyone right now.");
                Ah = Console.ReadLine();
                Console.WriteLine("Ah you remember Scarlett was the one that wasn't available, and the girl you are looking for was available and wanting to mingle. You say goodbye to Scarlett and end the call to continue your search for your potential soulmate");

        }
            static void HazelPath()
            {
                string Hello;
                string SugeKnight;
                string Gasp;

                Console.WriteLine("The phone rings, several rings pass and you think no one will pick up but then the phone is picked up. You hear a feminine voice on the other end, it is sweeter sounding, almost like if a bird were to talk");
                Hello = Console.ReadLine();
                Console.WriteLine("Hello! This is Hazel speaking, with who am I speaking with?");
                SugeKnight = Console.ReadLine();
                Console.WriteLine("Oh hello SugeKnight! It's nice to hear from you again, you were such a gentleman last night, I had a great time with you! I remeber you invited me to out to eat at Taco Bells sorry I didn't take you up on that offer but I don't really eat tacos.");
                Gasp = Console.ReadLine();
                Console.WriteLine("You gasp in shock, first off how could anyone hate on tacos and second the girl that you were looking for did end up taking your ofer up but remember that in the process of leaving you lost her in the crowd of people at the club. You say your goodbyes to Hazel and hang up to call the last girl.");
                
        }
            static void CocoPath()
            {

                string Hello;
                string SugeKnight;
                string TacoBells;

                Console.WriteLine("The phone rings, several rings pass and you think no one will pick up but then the phone is picked up. You hear a faminine voice on the other end, it is smooth and sweet sounding, almost like if a cloud were to talk");
                Hello = Console.ReadLine();
                Console.WriteLine("Uh..Hello? Who is this?");
                SugeKnight = Console.ReadLine();
                Console.WriteLine("OH MY GOD SUGEKNIGHT! I have been trying to figure out your contact info all day it sucks I couldn't find you last night I was really looking forward to eating Taco Bells!");
                TacoBells= Console.ReadLine();
                Console.WriteLine("You are in shock, the voice, the tone, the way she said Taco Bells, it all just clicked in your head and you remember her name was Coco, she was a beautiful fluffy siamese cat. And just like that everything clicks into place, you and Coco go on many dates together enjoying each other's company and you end up living a long and happy life together, the end.");

        }


        static void Nopath()
            {
                string No;
                string Yes;
                string CatClub;
                string Hello;
                string Um;
                string Uh;
                string Nuhuh;
                string Felines;
                string Yippie;
                string Okay;

                No = Console.ReadLine();
                Console.WriteLine("You really want to go out and look for- what could potentially be your soulmate.. like that??");
                Yes = Console.ReadLine();
                Console.WriteLine("Um..alright natural pheromones I guess. Anyways you head out to the club smelling questionable but you walk with confidence in every step you take.");
                CatClub = Console.ReadLine();
                Console.WriteLine("Walking into the club you spot the evening bartender polishing a few beer mugs. You go up to greet him.");
                Hello = Console.ReadLine();
                Console.WriteLine("Oh hey Sugeknight, hold off on asking anything right now I'm trying to figure out where this weird smell is coming from.");
                Um = Console.ReadLine();
                Console.WriteLine("Oh my god the smell is getting stronger somehow!?");
                Uh = Console.ReadLine();
                Console.WriteLine("What in god's green earth is making this smell?");
                Uh = Console.ReadLine();
                Console.WriteLine("Dude I don't mean to be rude but like.. the smell started when you walked in... I know this is awkward to ask but is that smell coming from you?");
                Nuhuh = Console.ReadLine();
                Console.WriteLine("Suge.. buddy.. that is a gnarly smell man, you left the house like that?");
                No = Console.ReadLine();
                Console.WriteLine("Okay well, since you're here already I assume you had a question, I'm always open to questions I mean I am a bartender but like once I answer you have to get out. Nothing personal you're just scaring the customers.");
                Felines = Console.ReadLine();
                Console.WriteLine("Here I'll just write down all the numbers I got last night from these girls and toss it to you.");
                Yippie = Console.ReadLine();
                Console.WriteLine("You wish the bartender could've helped with narrowing down the numbers to save some time, however because of your great decision to not clean up at all you ended up being rushed out the club.");
                Okay = Console.ReadLine();
                Console.WriteLine("As you head back to your house you dial every number that the bartender gave you... safe to say there are a lot of them, which begs the question, how in the world did you manage to get this many when today you reek.");
                Okay = Console.ReadLine();
                Console.WriteLine("Hours have passed and every cat you have called have all been vague with their answers or hung up when realizing that they weren't the cat you were looking for and not being given any further information.");
                Uh = Console.ReadLine();
                Console.WriteLine("Even more time passes and you begin to give up on this search, the lonliness and dispare setting in as you realize that because of your one simple decision to not take extra care in your appearence today you have now been doomed to a life of being an enternal bachelor, while some may call your life " +
                    "lucky it is anything but. But what's done is done and you end up dying a peaceful but lonely death");


                //End of stinky bad ending



            }


        
    }
}






   

