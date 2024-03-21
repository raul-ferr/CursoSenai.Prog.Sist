// criar um vetor que armazene 5 nomes //
/*
string[] alunos = new string[5] { "Joao", "pedro", "maria", "Bia", "Leo"};

int cont = 0;
while (cont < 5)
{
    Console.WriteLine(alunos[cont]);
    cont++;
}
*/

// criar um vetor que armazene 5 números //
/*
double[] num = new double[5] { 1, 2, 3, 4, 5 };
int cont = 0;
while (cont < 5)
{
    Console.WriteLine(num[cont]);
    cont++;
}
*/

// criar um vetor que armazene 3 notas e realize a soma das notas //
/*
 double[] notas = new double[3] 
         { 5.5, 6.5, 7 };
int i = 0;
double total = 0;
while(i < 3)
{
    Console.WriteLine(notas[i]);
    total += notas[i];
    i++;
}
Console.WriteLine(total);
*/

// criar um vetor qeu armazene 4 notas e realizar a média das notas //
/*
double[] notas = new double[4] 
     { 3, 4, 5, 7 };

int cont = 0;
double media = 0;
while(cont < 4)
{
    Console.WriteLine(notas[cont]);
    media += (notas[cont]) / 4;
    cont++;
}
Console.Write(media);
*/

// criar um vetor de 10 números. Escrever os números percorrendo o vetor de trás pra frente //
/*
double[] num = new double[10] 
   { 10, 2, 5, 4, 1, 6, 7, 8, 9, 10};

int cont = 9;      // ultima posição do vetor

while(cont >= 0)  // parar ma primeira posição
{
    Console.WriteLine(num[cont]);
    cont--;      // decrementar de 1 em 1
}
*/

// CRAIR UM VETOR COM 10 NÚMEROS E INFORMAR QUAL O MAIOR //
/*double[] num = new double[10]  
   {1, 20, 13, 4, 52, 6, 17, 28, 19, 10};

int cont = 0;
double maior = num[0];  // o numero entre parenteses declara a posicão do numero no caso é 1
while ( cont < 10)
{
    Console.WriteLine(num[cont]);
    if (num[cont] > maior)
    {
        maior = num[cont];
        
    }
cont++;
}   
Console.WriteLine("O maior número é: " + maior);
*/

// CRIANDO UM VETOR COM A VARIAVEL 'FOR' //

// CRAIR UM VETOR COM 10 NÚMEROS E INFORMAR QUAL O MAIOR 
/*
int[] num = new int[10] 
      { 1, 5, 6, 15, 23, 2, 33, 3, 40, 100 };
int maior = num[0];

for (int cont=0; cont<10; cont++)
{
    Console.WriteLine(num[cont]);
    if (num[cont] > maior)
    {
        maior = num[cont];
    }
}
Console.WriteLine("\n\no maior número é: " + maior);  // \n\n é colocando espaço entre os numeros da sequencia com a o informar do numero maior
*/

// CRIAR 2 VETORES: UM COM NOMES E OUTRO COM NOTAS. ESCREVA OS NOMES E AS NOTAS E VERIFICAR SE O ALUNO ESTÁ APROVADO OU REPROVADO // 02.08.23
/*
string[] nomes = new string[3] { "euclides", "josé", "biu guites" };
double[] notas = new double[3] { 8, 10, 6 };

for (int cont = 0; cont < 3; cont++)
{
    Console.Write("Nome= " + nomes[cont] + "Nota: " + notas[cont]);

    if (notas[cont] < 7)
    {
        Console.WriteLine(" REPROVADO");
    }
    else
    {
        Console.WriteLine(" APROVADO");
    }
}*/

// USANDO FOR COM O OPERADOR TERMINÁRIO //
/*
string[] nomes = new string[3] { "euclides", "josé", "biu guites" };
double[] notas = new double[3] { 8, 10, 6 };

for (int cont = 0; cont < 3; cont++)
{
    Console.Write("Nome= " + nomes[cont] + "Nota: " + notas[cont]);
    Console.WriteLine(notas[cont] < 7 ? " Reprovado" : " Aprovado"); // OPERADOR TERMINÁRIO NESSA LINHA //
}
*/

// CRIAR UM PROGRAMA PARA PEGAR A HORA DO SISTEMA E FAZER A SAUDAÇÃO : BOM DIA OU BOA TARDE DE ACORDO COM O HORÁRIO //

/*
DateTime agora = DateTime.Now;
Console.WriteLine("Agora:  {0}", agora.ToLongDateString());
string saudacao;

saudacao = agora.Hour > 12 ? "Boa Tarde" : "Bom dia";
Console.WriteLine("São {0} horas e {1} minutos", agora.Hour, agora.Minute);
Console.WriteLine(saudacao);
Console.ReadKey();
*/

// CRIAR UM PROGRAMA NO QUAL INCRENTA O VALOR DE 3 COM 10 NÚMEROS ( 1, 4, 7, 10, 13, 16, 19, 22, 25, 28) //
/*
int A = 1;
int R = 3;
int valor = A;

for(int i=0; i < 10; i++)
{
    Console.WriteLine(valor);
    valor += R;   // valor = valor + R 
}
*/

// LOGICA DE PROGRAMAÇÃO 04.08.23 COMANDO READLINE
// LER UM NUMERO
/*
Console.WriteLine("Escreva um número");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Você Digitou: " + n);
*/


// LER UM NUMERO. LER UM SEGUNDO NUMERO  E SOMAR OS DOIS NUMEROS //
/*
Console.WriteLine("Escreva um número");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva outro número");
int n2 = int.Parse(Console.ReadLine());

int soma = n1 + n2;

Console.WriteLine("Soma: " + soma);
*/

// LER UM NUMERO. LER UM SEGUNDO NUMERO E LER QUAL OPERAÇÃO O USUARIO DESEJA REALIZAR (1.SOMA. 2.SUBTRAÇÃO)
/*
Console.WriteLine("Digite a opção desejada:\n 1.soma 2.subtração");
int op = int.Parse(Console.ReadLine());
int resultado = 0 ;

Console.WriteLine("Escreva um número");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Escreva outro número");
int n2 = int.Parse(Console.ReadLine());

if (op == 1) { resultado = n1 + n2; }
if (op == 2) { resultado = n1 - n2; }

Console.WriteLine("Resultado: " + resultado);
*/

// LER UM NUMERO. LER UM SEGUNDO NUMERO E LER QUAL OPERAÇÃO O USUARIO DESEJA REALIZAR (1.SOMA. 2.SUBTRAÇÃO)
// CASO A PESSOA DIGITAR OUTRO NÚMERO APARECER UMA MENSAGEM COM OPÇÃO INVÁLIDA 

Console.WriteLine("Digite a opção desejada:\n 1.soma 2.subtração");
int op = int.Parse(Console.ReadLine());
int resultado = 0;
if (op == 1 || op == 2)
{
    Console.WriteLine("Escreva um número");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Escreva outro número");
    int n2 = int.Parse(Console.ReadLine());

    if (op == 1) { resultado = n1 + n2; }
    else if (op == 2) { resultado = n1 - n2; }
}
else
{
    Console.WriteLine("Opção Inválida.");
}

Console.WriteLine("Resultado: " + resultado);


// LER UM NUMERO. LER UM SEGUNDO NUMERO E LER QUAL OPERAÇÃO O USUARIO DESEJA REALIZAR (1.SOMA. 2.SUBTRAÇÃO E 3.SAIR)
/*
int resultado = 0;
int op = 0;
while (op != 3)
{
    Console.WriteLine("Digite a opção desejada:\n 1.soma 2.subtração 3.Sair");
    op = int.Parse(Console.ReadLine());
    if (op == 3) { break; }

    Console.WriteLine("Escreva um número");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Escreva outro número");
    int n2 = int.Parse(Console.ReadLine());

    if (op == 1) { resultado = n1 + n2; }
    else if (op == 2) { resultado = n1 - n2; }
}*/