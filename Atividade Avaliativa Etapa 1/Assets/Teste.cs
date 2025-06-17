using UnityEngine;

public class Teste : MonoBehaviour
{
    Personagem Raul = new Personagem();
    Mercenário Dex = new Mercenário();
    void Start()
    {
        Raul.AtribuirNome("Raul");
        Raul.AtribuirForca_Ataque(15);
        Raul.AtribuirForca_do_pulo(7);
        Raul.AtribuirEnergia(12);
        Raul.AtribuirVelocidade(10);
        
        Dex.AtribuirNome("Dex");
        Dex.AtribuirForca_Ataque(13);
        Dex.AtribuirForca_do_pulo(8);
        Dex.AtribuirEnergia(10);
        Dex.AtribuirVelocidade(11);
        Dex.UsarContratoDeSangue(Raul);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
