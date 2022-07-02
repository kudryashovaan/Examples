// Вид 1 - без аргументов, ничего не возвращают
void Method1(){
    Console.WriteLine("Автор ...");
}
// Вызов метода1
Method1();

// Вид 2 - ничего не возвращают но принимают аргументы
void Method2(string msg, int count){
    int i = 0;
    while (i<count){
        Console.WriteLine(msg);
        i++;
    }
    
}
// Вызов метода2
Method2("Text", 4);
/*или*/ Method2(msg: "Text", count: 4);

// Вид 3 - что-то возвращают но ничего не принимают
int Method1(){
    return DateTime.Now.Year;
}
// Вызов метода3
int year = Method3();
Console.WriteLine(year);

//Вид 4 - что-то принимают и возвращают
string Method4(int count, string text){
    string result = String.Empty;
    for(int i = 0; i<count; i++){
        result = result + text;
    }
    return result;
}
// Вызов метода4
string res = Method4(10, "asdf");
Console.WriteLine(res);


