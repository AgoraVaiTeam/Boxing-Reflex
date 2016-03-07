using Assets.Scripts.Enum;

public interface ICirculo
{
    DirectionEnum tipo { get; }
    float pegaTamanho();
    float pegaBaseDano();
}