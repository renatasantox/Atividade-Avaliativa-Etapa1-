using UnityEngine;

public class Mercenario : Personagem
{
    public string habilidadeEspecial;
    public string arma;
    
    public void AtribuirhabilidadeEspecial(string habilidadeEspecial)
    {
        this.habilidadeEspecial = habilidadeEspecial;
    }

    public string HabilidadeEspecial()
    {
        return this.habilidadeEspecial;
    }

    public void AtribuirArma(string arma)
    {
        this.arma = arma;
    }

    public string Arma()
    {
        return this.arma;
    }

    public void UsarContratoDeSangue(Personagem personagem)
    {
        personagem.AtribuirEnergia(personagem.Energia()-100);
        Debug.Log(personagem.Nome()+" agora tem "+ personagem.Energia()+ " de energia" );
    }
}
