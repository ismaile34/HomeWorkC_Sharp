int Prompt(string message){
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
int n = Prompt("Введите пятизначное число >");
int temp = n;
int numberRevers = 0;
while (temp > 0) {
    int value = temp % 10;
    numberRevers = numberRevers * 10 + value;
    temp /= 10;
}
if (numberRevers == n){

    System.Console.WriteLine ($"Число {n} является палиндромом");
}
else{
    System.Console.WriteLine ($"Число {n} не является палиндромом");;
}