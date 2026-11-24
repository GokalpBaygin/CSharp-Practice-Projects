using UnityEngine;

public class NullSafetyExample : MonoBehaviour
{
    [ContextMenu("NullGuvenlikTesti")]
    void NullGuvenlikTesti()
    {
        // Example 1: Null coalescing with a default value
        string urunAdi = null;
        Debug.Log(urunAdi?.Length ?? 0);

        // Example 2: Null conditional operator
        urunAdi = "Demir";
        Debug.Log(urunAdi?.Length);

        // Example 3: Safe method invocation
        string mesaj = "merhaba atlas";
        Debug.Log(mesaj?.ToUpper());

        // Example 4: Fallback message for null values
        mesaj = null;
        Debug.Log(mesaj?.ToUpper() ?? "Mesaj Bulunamadı");
    }
}
