/* int numerointeiro = 10;

double numerodouble = numerointeiro;

double pi = 3.14;

int numint = (int)pi;

string numtexto = "123";

int numero = Convert.ToInt32(numtexto);

//Formatação de strings
//Concatenação

string nome = "Hirana";
string mensagem = "Meu nome é " + nome + "!";

//Interpolação

string nomenew = "Niralay";
int idade = 777;
string mensagem2 = $"Olá! Meu nome é {nomenew} e tenho {idade} anos!";

//Placeholders

string nomenovo = "ArintheL";
int idade2 = 20;
string mensagem3 = string.Format("Olá! Meu nome é {0} e tenho {1} anos!", nomenovo, idade2); */



using System.Security.Cryptography;

Console.WriteLine("Digite seu nome:");

string? nome = Console.ReadLine();

Console.WriteLine("Digite sua idade:");

int? idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Olá! Meu nome é {nome} e tenho {idade} anos!");