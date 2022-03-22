Convenções de nomenclatura
Há várias convenções de nomen entre as convenções a considerar ao escrever código C#.

Nos exemplos a seguir, qualquer uma das diretrizes referentes aos elementos marcados também é aplicável ao trabalhar com elementos e , que devem ser visíveis para public protected protected internal chamadores externos.

Pascal Case
Use o pascal casing ("PascalCasing") ao nomear class um record , ou struct .

public class DataService
{
}

public record PhysicalAddress(
    string Street,
    string City,
    string StateOrProvince,
    string ZipCode);