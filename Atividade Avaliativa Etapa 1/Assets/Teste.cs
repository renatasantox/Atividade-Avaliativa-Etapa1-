using UnityEngine;

public class Teste : MonoBehaviour
{
    Personagem Raul = new Personagem();
    Mercenario Dex = new Mercenario();
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
        
        Dex.UsarContratoDeSangue(Raul);

        if (Raul.Energia() <= 0)
        {
            Debug.Log("O " + Raul.Nome() + " ficou sem energia");
        }
        else
        {
            Debug.Log("O " + Raul.Nome() + " ainda tem "+ Raul.Energia() + "energia");
        }    
    }
    
    void Update()
    {
        
    }
}
