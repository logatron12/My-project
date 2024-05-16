/*using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CablesTests
{
    private GameObject gameObject;
    private Cables cables;
    private Switch mockSwitch;

    [SetUp]
    public void SetUp()
    {
        gameObject = new GameObject();
        cables = gameObject.AddComponent<Cables>();
        mockSwitch = new GameObject().AddComponent<Switch>();
        cables.s = mockSwitch;
    }

    [TearDown]
    public void TearDown()
    {
        Object.DestroyImmediate(gameObject);
        Object.DestroyImmediate(mockSwitch.gameObject);
    }

    [Test]
    public void Cables_DefaultValues()
    {
        // Test default values of Cables
        Assert.IsFalse(cables.playerLan);
        Assert.IsFalse(cables.playerPower);
        Assert.IsFalse(cables.playerConsol);
        Assert.IsFalse(cables.playerSerial);
        Assert.IsFalse(cables.playerLan2);
        Assert.IsFalse(cables.playerPower2);
        Assert.IsFalse(cables.playerConsol2);
        Assert.IsFalse(cables.playerSerial2);
        Assert.IsNull(cables.nombre);
    }

    [Test]
    public void Cables_Tageo_SetsNombre()
    {
        // Test that the Tageo method sets the nombre correctly
        mockSwitch.Nombre = "TestSwitch";
        cables.Tageo();
        Assert.AreEqual("TestSwitch", cables.nombre);
    }
}
*/