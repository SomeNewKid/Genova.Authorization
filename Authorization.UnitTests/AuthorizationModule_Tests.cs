// This file is part of the Genova project licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

namespace Genova.Authorization.UnitTests;

public class AuthorizationModule_Tests
{
    [Fact]
    public void Module_name()
    {
        // Act & Assert
        Assert.Equal("Authorization", AuthorizationModule.Name);
    }
}
