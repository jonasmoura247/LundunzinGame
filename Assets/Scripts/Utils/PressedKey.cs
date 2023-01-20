using UnityEngine;

namespace Utils.PressedKey
{
  public static class Pressed
  {
    public static bool Espcape() { return (Input.GetKeyDown(KeyCode.Escape)); }
    public static bool Space() { return (Input.GetKeyDown(KeyCode.Space)); }
    public static bool F2() { return (Input.GetKeyDown(KeyCode.F2)); }
    public static bool I() { return (Input.GetKeyDown(KeyCode.I)); }
    public static bool J() { return (Input.GetKeyDown(KeyCode.J)); }
    public static bool K() { return (Input.GetKeyDown(KeyCode.K)); }
    public static bool P() { return (Input.GetKeyDown(KeyCode.P)); }
    public static bool KeypadPlus() { return (Input.GetKeyDown(KeyCode.KeypadPlus)); }
    public static bool C() { return (Input.GetKeyDown(KeyCode.C)); }
    public static bool M() { return (Input.GetKeyDown(KeyCode.M)); }
    public static bool H() { return (Input.GetKeyDown(KeyCode.H)); }
    public static bool R() { return (Input.GetKeyDown(KeyCode.R)); }
    public static bool Q() { return (Input.GetKeyDown(KeyCode.Q)); }
  }
}
