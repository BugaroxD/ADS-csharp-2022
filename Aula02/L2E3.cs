 using System;
 public class L2E3
 {
    public static void Main() 
    {
        // Variaveis fixas do jogo
        string oculta = "JACKSON";
        string corpo[] = { "", "sua cabeça", "seu braço direito", "seu braço esquerdo", "sua perna direita",
                " sua perna esquerda" };
        int tentativas = 5;
        int cont = 1;

        string palavra;

        Console.WriteLine("Bem vindo ao jogo da forca! ");
        Console.WriteLine("Você tem 5 tentativas para tentar acertar a palavra secreta! ");

        do {
            Console.WriteLine("Digite a " + cont + "ª palavra! ");
            palavra = Convert.ToInt32(Console.ReadLine());
            palavra = palavra.toUpperCase();
            if (palavra.equals(oculta)) {
                Console.WriteLine("Parabéns! Você adivinhou a palavra oculta.");
                break;
            } else {
                Console.WriteLine("Você perdeu " + corpo[tentativas] + ".");
                tentativas--;
                if (tentativas == 0) {
                    Console.WriteLine("Você foi enforcado. Fim de jogo!");
                } else {
                    Console.WriteLine("Tem apenas mais " + tentativas + " tentativas.");
                    cont++;
                }
            }
        } while (tentativas != 0);

        scanner.close();
    }
}
