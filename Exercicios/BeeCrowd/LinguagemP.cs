namespace Exercicios.BeeCrowd
{
    internal class LinguagemP
    {

        /*
         Uma brincadeira que crianças adoram é se comunicar na língua do P, 
        acrescentando pê antes de cada sílaba, como uma forma de código para dificultar que outras pessoas entendam a conversa (pê-va pê-mos pê-no pê-ci pê-ne pê-ma?).
        Jacy e Kátia adaptaram a língua do P para mensagens eletrônicas,
        acrescentando a letra P minúscula ‘p’ antes de cada letra das palavras de uma mensagem.

        Sua tarefa é escrever um programa que decodifique uma mensagem escrita na língua do P eletrônica de Jacy e Kátia.
         */

        public static void LiguaDoP()
        {
            string mensagemCodificada = Console.ReadLine();
            if (string.IsNullOrEmpty(mensagemCodificada)) return;

            for (int i = 0; i < mensagemCodificada.Length; i++)
            {
                if (mensagemCodificada[i] == ' ')
                {
                    Console.Write(" ");
                }
                else
                {
                    if (i + 1 < mensagemCodificada.Length)
                    {
                        Console.Write(mensagemCodificada[i + 1]);
                        i++;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
