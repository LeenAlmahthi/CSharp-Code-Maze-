//When an investigator collects a piece of digital evidence
// some information should be permanently attached to it.

using System.Runtime.CompilerServices;
public class Evidence
{
    public Guid Id { get; init; }
    public string IP { get; set; }
    public string MacAdreess { get; init; }
    public string InvestigatorName { get; init; }
    public string Device { get; init; }
    public DateTime CollectedAt { get; init; }
    public Evidence(string IP, string MacAdreess, string Device)
    {
        Id = Guid.NewGuid();
        this.IP = IP;
        this.MacAdreess = MacAdreess;
        this.Device = Device;
        CollectedAt = DateTime.Now;
        InvestigatorName = "Leen";
    }
    public override string ToString()
    {
        return $"Data Id: {Id}\n IP: {IP}\nMacAdreess: {MacAdreess}\nDevice: {Device}\nCollectedAt: {CollectedAt}\nInvestigatorName: {InvestigatorName}\n ";
    }
}