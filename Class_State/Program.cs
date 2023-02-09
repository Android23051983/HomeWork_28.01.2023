// See https://aka.ms/new-console-template for more information
using static System.Console;
State state = new();
//state.Print();//ошибка так как метод private
state.PrintInternal();//ошибки нет так как метод internal
state.PrintPublic();

class State//все равно, что internal State
{
    string defaultVar = "default";//все равно, что private string
    private string privateVar = "private"; //поле доступно только из текущего класса
    //доступно из текущего класса и производных классов, которые определены в этом проекте
    protected private string protectedPrivateVar = "protected private";
    protected string protectedVar = "protected";//доступно из текущего класса и производных классов
    internal string internalVar = "internal";//доступно в любом месте текущего проекта
    //доступно в любом месте текущего проекта и из классов-наследников в других проектах
    protected internal string protectedInternalVar = "protected internal";
    public string publicVar = "public";//доступно в любом месте программы, а так же для других программ и сборок

    void Print() => WriteLine(defaultVar);
    private void PrintPrivate() => WriteLine(privateVar);
    protected private void PrintProtectedPrivate() => WriteLine(protectedPrivateVar);
    protected void PrintProtected() => WriteLine(protectedVar);
    internal void PrintInternal() => WriteLine(internalVar);
    protected internal void PrintProtectedInternal() => WriteLine(protectedInternalVar);
    public void PrintPublic() => WriteLine(publicVar);
}