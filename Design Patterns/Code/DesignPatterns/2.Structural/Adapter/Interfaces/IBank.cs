using DesignPatterns._2.Structural.Adapter.Dto;

namespace DesignPatterns._2.Structural.Adapter.Interfaces
{
    public interface IBank
    {
        OwnResponseDto ProcessLoan(OwnRequestDto ownRequestDto);
    }
}
