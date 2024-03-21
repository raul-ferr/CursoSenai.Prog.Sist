/* CÓDIGO COM MULTIPLO DE 6
int n = 6;

while (n <= 200)
{
    if (n % 2 == 0 && n % 3 == 0)
    {
        Console.WriteLine(n);
    }
    n++;
} 
*/

/* CRIAR UM PROGRAMA QUE ESCREVA OS NÚMEROS DE 10 A 1 UTILIZANDO O WHILE
 
int n = 10;

while (n >= 0)
{
    Console.WriteLine(n);
    n--;

} */

/* CRIAR UM PROGRAMA QUE ESCREVA O FATORIAL DE N 5! = 5*4*3*2*1 = 120

int n = 5;
int resultado = 1;

while (n >= 1)
{
    Console.WriteLine(resultado *= n);
    n--;
} */

/* OUTRA MANEIRA DE FAZER O PROGRAMA ACIMA MOSTRANDO MAIS NITIDAMENTE

int n = 5;
int resultado = 1;

while (n >= 1)
{
    Console.Write(resultado + "X" + n + "=");
    resultado *= n;
    Console.WriteLine(resultado);
    n--;
}*/

/* JUROS COMPOSTO USANDO JUROS SIMPLES
//JUROS = CAPITAL * TAXA * TEMPO
//MONTANTE = CAPITAL + JUROS

double capital = 100;
double taxa = 0.10; //10%
int tempo = 12;
int contador = 1;
double montante = 0;
double juros = 0;

Console.WriteLine("Início: " + capital);
while (contador <= tempo)
{
    juros = capital * taxa;            //CALCULO JUROS
    montante = capital + juros;        //CALCULO MONTANTE
    Console.WriteLine(contador + " o mês: " + montante);
    capital = montante;                //ATUALIZA O CAPITAL
    contador++;
}*/


string senhaDigitada;
string senhaPadrao = "Senac";

Console.WriteLine("Digite a senha:");
senhaDigitada = Console.ReadLine();
Console.WriteLine("Senha digita: "+senhaDigitada);

while (senhaDigitada != senhaPadrao)
{
    Console.WriteLine("Digite a senha novamente:");
    senhaDigitada = Console.ReadLine();
}
Console.WriteLine("Bem-Vindo");