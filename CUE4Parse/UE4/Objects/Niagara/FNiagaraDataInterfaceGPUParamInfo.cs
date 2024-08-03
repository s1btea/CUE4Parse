using CUE4Parse.UE4.Readers;
using CUE4Parse.UE4.Versions;

namespace CUE4Parse.UE4.Objects.Niagara;

public class FNiagaraDataInterfaceGPUParamInfo : IUStruct
{
    /** Symbol of this DI in the hlsl. Used for binding parameters. */
    public string DataInterfaceHLSLSymbol;

    /** Name of the class for this data interface. Used for constructing the correct parameters struct. */
    public string DIClassName;

    /** Information about all the functions generated by the translator for this data interface. */
    public FNiagaraDataInterfaceGeneratedFunction[] GeneratedFunctions = [];

    public FNiagaraDataInterfaceGPUParamInfo(FArchive Ar)
    {
        DataInterfaceHLSLSymbol = Ar.ReadFString();
        DIClassName = Ar.ReadFString();

        if (FNiagaraCustomVersion.Get(Ar) >= FNiagaraCustomVersion.Type.AddGeneratedFunctionsToGPUParamInfo)
        {
            GeneratedFunctions = Ar.ReadArray(() => new FNiagaraDataInterfaceGeneratedFunction(Ar));
        }
    }
}
