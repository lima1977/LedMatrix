﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LedMatrixDevArea.Properties {
    using System;
    
    
    /// <summary>
    ///   Uma classe de recurso de tipo de alta segurança, para pesquisar cadeias de caracteres localizadas etc.
    /// </summary>
    // Essa classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    // através de uma ferramenta como ResGen ou Visual Studio.
    // Para adicionar ou remover um associado, edite o arquivo .ResX e execute ResGen novamente
    // com a opção /str, ou recrie o projeto do VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Retorna a instância de ResourceManager armazenada em cache usada por essa classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LedMatrixDevArea.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Substitui a propriedade CurrentUICulture do thread atual para todas as
        ///   pesquisas de recursos que usam essa classe de recurso de tipo de alta segurança.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        ///&lt;LedMatrixSymbolFile Comments=&quot;No comments&quot;&gt;
        ///	&lt;LedMatrixSymbolFont FontName=&quot;Default&quot;&gt;
        ///		&lt;LedMatrixSymbol SymbolCode=&quot;32&quot; Description=&quot;Space&quot;&gt;
        ///			&lt;LedLine LineNumber=&quot;0&quot; LineLedOn=&quot;__&quot;/&gt;
        ///		    &lt;LedLine LineNumber=&quot;1&quot; LineLedOn=&quot;__&quot;/&gt;
        ///		    &lt;LedLine LineNumber=&quot;2&quot; LineLedOn=&quot;__&quot;/&gt;
        ///		    &lt;LedLine LineNumber=&quot;3&quot; LineLedOn=&quot;__&quot;/&gt;
        ///		    &lt;LedLine LineNumber=&quot;4&quot; LineLedOn=&quot;__&quot;/&gt;
        ///			&lt;LedLine LineNumber=&quot;5&quot; LineLedOn=&quot;__&quot;/&gt;
        ///			&lt;LedLine LineNumber=&quot;6&quot; LineLedOn=&quot;__&quot;/&gt;        /// [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string LedMatrixSymbolFile {
            get {
                return ResourceManager.GetString("LedMatrixSymbolFile", resourceCulture);
            }
        }
    }
}
