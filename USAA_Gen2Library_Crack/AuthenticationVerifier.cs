// Decompiled with JetBrains decompiler
// Type: USAA_Gen2Library.AuthenticationVerifier
// Assembly: USAA_Gen2Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 89D480B7-0DAE-4B5B-983E-3E191ABD46D7
// Assembly location: C:\Users\Kevin\Downloads\MUNCS Express 2 0130\USAA_Gen2Library.dll

using System.IO;
using System.Text.RegularExpressions;

namespace USAA_Gen2Library
{
    public class AuthenticationVerifier
    {
        private string encPrivateKey = "<RSAKeyValue><Modulus>x2+VkhJ21TIvoIjWQ4ediMGJymzUVpK4iD4WhHgysbgCkms3wzT0oLoJm5oy/CPTBHDnCBSY2j5F+GVe7wCRbH08lCDKIl1kGL29NWvqpwd22494UfX79uv26+/4VIzM9drHCVgCGGLt2inhj45/MVA+PiX+TTFtnWMEroVUHRk=</Modulus><Exponent>AQAB</Exponent><P>1aKvE/UytZxl4FRu6SezhfOLW0dd+4AJt/pQcTnTWDfNRoubdFW0gQHhiFBkf2ZLtDd+grGuFpZGCHDwYkPTjw==</P><Q>7vwMxmDbQFP0FL51jRPJ079FAc8OqiFrhOJsZFCx4KTp5ewAzj+nwr/W6k3YhO9TpvDot8D1itHaoobTwFOQ1w==</Q><DP>o1PU9jUnp6ECYhcrFCW+IlKn4AkX2QdyZq2Ago/q/C7tSVnCZ5Z+gYKmokiUDLJwfj9PASxGJA6PTDTMEtQ4EQ==</DP><DQ>x187ARy4jNf9Hnkt9D33+FDvLu0gXMp4umly59VyL+kkwI28tlPgjtYgY2QCKBTJAtKkMvglYGRmM4Srjx2oDQ==</DQ><InverseQ>ZaQ+sUOpLYpiMRYY6cT1/mR2sMtDgoZ/WMevI6/UgERw9NSw9CjLZeDPOTOZKlYD5CpjbwDTeygZe5YGqpeBLA==</InverseQ><D>uB60H18chkcG4VZzOXUCYzcKVu+SOTrLUjy/3Rx68MfI2BRULsu87IXUSOtbFpycPAVfxX3+f73uKxyrQEtt9PDsCLdCg3Pez8vCMWwggoIB87RX3LUKWZ+mtMXZiwcbTULv4O1erW6594aRiKo1JqL1vq1HCwwDhNkGU31EbeE=</D></RSAKeyValue>";
        private string signPublicKey = "<RSAKeyValue><Modulus>7XlcbSI8McvYMREIkFum08wM/F5Seix0r2Nctsc9yMdy5ID8sFRE6aHQdXA60KhrrkAIlycboBPpYvFfxjGgEspI/Dic6h/f5VPMkR6YlJOSDdS9Y21T10mkD0AS9avElsV4SDPdBw5h/BB5uKxaytRhSb3sWJ8DeBQ7IzvuH/E=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        private string salt = "cad8d642e68d703bb1fb6e72c0a257ea15275f8690743a1d68fca8520459d15f27912162376c86e41f8845bbde9d947e22aa910e885238dd5636b1ce0e1f2b90";

        public bool DecryptandVerify(ref string message)
        {
            return true;
        }
    }
}
