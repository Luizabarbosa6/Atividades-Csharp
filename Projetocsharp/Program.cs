using Projetocsharp.Common.models;

List<string> listastring = new List<string>();

listastring.Add("SP");
listastring.Add("PE");
listastring.Add("MG");

Console.WriteLine($"Itens na minha lista: {listastring.Count}- capacidade {listastring.Capacity}");

listastring.Add("BA");

Console.WriteLine($"Itens na minha lista: {listastring.Count}- capacidade {listastring.Capacity}");

listastring.Remove("BA");

Console.WriteLine($"Itens na minha lista: {listastring.Count}- capacidade {listastring.Capacity}");













/*
for(int contador = 0; contador < listastring.Count; contador++)
{
    Console.WriteLine($"Posição N° {contador} - {listastring[contador]}");
}

Console.WriteLine("---------------------");

int contadorforeach = 0;
foreach(string item in listastring)
{
     Console.WriteLine($"Posição N° {contadorforeach} - {listastring[contadorforeach]}");
     contadorforeach++;
}*/












/*int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;*/
//arrayInteiros[3] = 1;

//int[] arrayInteirosDobrado = new int [arrayInteiros.Length * 2];
//Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
//Percorrendo o array com for
//arrayInteiros.Length (o length serve para o contador ir até a capacidade do array
/*for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
}


Console.WriteLine("---------------------- ");
// percorrendo o array co foreach

int contadorForeach = 0;
foreach(int valor in arrayInteiros)
{
  Console.WriteLine($"Posição N° {contadorForeach} - {valor}");
  contadorForeach++;
}
*/

/*
Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Luiza";
pessoa1.Idade = 19;
pessoa1.Apresentar();
*/

/*string opcao; 
bool exibirMenu = true;

while(true)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente ");
    Console.WriteLine("3 - Apagar cliente ");
    Console.WriteLine("4 - Encerrar");  

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
        Console.WriteLine("Cadastrar cliente");
        break;

        case "2":
        Console.WriteLine("Buscar cliente");
        break;

        case "3": 
        Console.WriteLine("Apagar cliente");
        break;

        case"4":
        Console.WriteLine("Encerrar");
        exibirMenu = false;
        //Environment.Exit(0);
        break;

        default:
        Console.WriteLine("Opção invalida");
        break;
    }

}
*/



/*int soma = 0, numero = 0; 

do 
{
    Console.WriteLine("Digite um Número (Digite 0 para parar): ");
    numero = Convert.ToInt32 (Console.ReadLine());

    soma += numero;
}while(numero != 0);

Console.WriteLine($"Total da soma dos numeros é: {soma}");
*/


/*
int numero = 5;
int contador = 0;

while(contador <=10)
{
 Console.WriteLine($"{contador + 1}° Execução: {numero} x {contador} = {numero * contador}");
 contador++;

 if(contador == 5)
 {
    break;
 }
}
*/



/*
int numero = 5;

for(int contador = 0; contador <=10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}
*/




/*
Calculadora calc = new Calculadora();

calc.Somar(10, 30);
calc.Subtrair(10, 50); 
calc.Dividir(2, 2);
calc.Potencia(3, 3);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
calc.RaizQuadrada(9);
*/




/*bool choveu = false; 
bool estaTarde = false; 

if (!choveu &&  !estaTarde){
    Console.WriteLine("Vou pedalar");
}
else{
    Console.WriteLine("Vou pedalar outro dia!");
}

*/



/*
bool possuipresencaminima = false; 
double media = 7.5; 
if(possuipresencaminima && media >= 7){
 Console.WriteLine("Aprovado!");
}
else{
    Console.WriteLine("Reprovado");
}
*/



/*bool ehMaiorDeIdade = true;

bool possuiAutorizacaoDosPais = false; 

if(ehMaiorDeIdade|| possuiAutorizacaoDosPais)
{
Console.WriteLine("Entrada liberada!");
}
else
{
Console.WriteLine("Entrada não liberada.");
}
*/


           /*Console.WriteLine("Digite uma letra: ");
            string letra = Console.ReadLine();

        switch(letra)
        {
            case "A": 
            case "E":
            case "I":
            case "O":
            case "U":
               Console.WriteLine("sua letra é uma Vogal");
        break;

         default:
         Console.WriteLine("sua letra não é uma Vogal");
        break;
        }*/


    
    