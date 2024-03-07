using System;

class Program
{
	static void Main(string[] args)
	{
		// Sequência a)
		int proximoA = ProximoElementoA(7);
		Console.WriteLine("Próximo elemento da sequência a): " + proximoA);

		// Sequência b)
		int proximoB = ProximoElementoB(64);
		Console.WriteLine("Próximo elemento da sequência b): " + proximoB);

		// Sequência c)
		int proximoC = ProximoElementoC(36);
		Console.WriteLine("Próximo elemento da sequência c): " + proximoC);

		// Sequência d)
		int proximoD = ProximoElementoD(64);
		Console.WriteLine("Próximo elemento da sequência d): " + proximoD);

		// Sequência e)
		int proximoE = ProximoElementoE(8);
		Console.WriteLine("Próximo elemento da sequência e): " + proximoE);

		// Sequência f)
		int proximoF = ProximoElementoF(19);
		Console.WriteLine("Próximo elemento da sequência f): " + proximoF);
	}

	// Implementação das funções para cada sequência

	static int ProximoElementoA(int ultimoElemento)
	{
		return ultimoElemento + 2;
	}

	static int ProximoElementoB(int ultimoElemento)
	{
		return ultimoElemento * 2;
	}

	static int ProximoElementoC(int ultimoElemento)
	{
		int raiz = (int)Math.Sqrt(ultimoElemento);
		return (raiz + 1) * (raiz + 1);
	}

	static int ProximoElementoD(int ultimoElemento)
	{
		int raiz = (int)Math.Sqrt(ultimoElemento);
		return (raiz + 2) * (raiz + 2);
	}

	static int ProximoElementoE(int ultimoElemento)
	{
		int a = 1;
		int b = 1;
		int proximo = a + b;

		while (proximo <= ultimoElemento)
		{
			a = b;
			b = proximo;
			proximo = a + b;
		}

		return proximo;
	}

	static int ProximoElementoF(int ultimoElemento)
	{
		return ultimoElemento + 3;
	}
}
