using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
  public class RefreshTokenDto
  {
    public string AccessToken { get; set; }
    public string RefreshToken { get; set; }
  }
}