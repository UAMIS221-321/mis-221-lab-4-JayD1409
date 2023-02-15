//start main 
int userChoice = GetUserChoice(); 
while(userChoice!=3) {
    RouteEm(userChoice);
    userChoice = GetUserChoice();
    Console.Clear();
}

static int GetUserChoice()
{
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if(IsValidChoice(userChoice)){
        return int.Parse(userChoice);
    }
    else return 0;
}
static void DisplayMenu(){
    System.Console.WriteLine("Enter 1 to display full triangle/Enter 2 to display partial triangle/Enter 3 to exit");
}
static bool IsValidChoice(string userInput){
    if(userInput=="1" || userInput=="2" || userInput=="3"){
        return true; 
    }
    return false; 
}
static void DisplayFull(){
  Random rnd = new Random();
  int number = rnd.Next(3,10);
  for(int i = 0; i <= number; i++){
    for(int j = 0; j < i; j++){
        Console.Write("O");
        
    }
    System.Console.WriteLine();
  }
  PauseAction();
}

static void DisplayPartial(){
    Random rand = new Random();
  int number = rand.Next(3,10);
    for(int i = 0; i <= number; i++){
    for(int j = 0; j <= i; j++){
        int newNumber = rand.Next(2);
        if (newNumber == 0){
            Console.Write(" ");
        }
        else if(newNumber == 1 ) {
            Console.Write("O");
        }
    }
    System.Console.WriteLine();
}
PauseAction();
}

static void DisplayExit(){
    System.Console.WriteLine("Enter 3 to exit");
    PauseAction();
}
static void RouteEm(int menuChoice){
    if(menuChoice==1){
        DisplayFull();
    }
    else if(menuChoice==2){
        DisplayPartial();
    }
    else if(menuChoice==3){
        DisplayExit();
    }
}
static void PauseAction(){
    System.Console.WriteLine("Press any key to continue");
    Console.ReadLine();
}

