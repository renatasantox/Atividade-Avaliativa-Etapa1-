using NUnit.Framework.Constraints;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    [SerializeField] public string nome;
    [SerializeField] public int forca_ataque;
    [SerializeField] public float forca_do_pulo;
    [SerializeField] public int energia;
    [SerializeField] public float velocidade;
    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }

    public string Nome()
    {
        return this.nome;
    }

    public void AtribuirForca_Ataque(int forca_ataque)
    {
        this.forca_ataque = forca_ataque;
    }

    public int Forca_Ataque()
    {
        return this.forca_ataque;
    }

    public void AtribuirForca_do_pulo(int forca_do_pulo)
    {
        this.forca_do_pulo = forca_do_pulo;
    }

    public float Forca_Do_Pulo()
    {
        return this.forca_do_pulo;
    }

    public void AtribuirEnergia(int energia)
    {
        this.energia = energia;
    }

    public int Energia()
    {
        return this.energia;
    }

    public void AtribuirVelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }

    public float Velocidade()
    {
        return this.velocidade;
    }

    public bool CompareVelocidade(Personagem personagem)
    {
        if (this.velocidade > personagem.Velocidade())
        {
            return true;
        }
        return false;
    }
}
