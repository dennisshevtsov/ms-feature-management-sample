using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement;

namespace MsFeatureManagementSample.Web;

[ApiController]
public sealed class FeatureController(IFeatureManager featureManager) : ControllerBase
{
  private readonly IFeatureManager _featureManager = featureManager ?? throw new ArgumentNullException(nameof(featureManager));

  [HttpGet("api/feature/{featureName}")]
  public async Task<IActionResult> Get(string featureName) =>
    Ok(await _featureManager.IsEnabledAsync(featureName));
}
