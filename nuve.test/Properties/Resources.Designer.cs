﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nuve.Test.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Nuve.Test.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///
        ///&lt;morphology lang=&quot;Tr-TR&quot;&gt;
        ///
        ///  &lt;graph&gt;
        ///
        ///    &lt;source id=&quot;ISIM&quot;&gt;
        ///      &lt;target id=&quot;IC_COGUL_lAr&quot; /&gt;
        ///      &lt;target id=&quot;IC_SAHIPLIK_BEN_(U)m&quot; /&gt;
        ///      &lt;target id=&quot;IC_SAHIPLIK_SEN_(U)n&quot; /&gt;
        ///      &lt;target id=&quot;IC_AITLIK_ki&quot;&gt;
        ///        &lt;conditions flag=&quot;Or&quot;&gt;
        ///          &lt;condition morpheme=&quot;Source&quot; operator=&quot;HasFlags&quot; operand=&quot;zaman&quot; /&gt;
        ///        &lt;/conditions&gt;
        ///      &lt;/target&gt;
        ///    &lt;/source&gt;
        ///
        ///    &lt;source id=&quot;FIIL&quot; terminal=&quot;false&quot;&gt;
        ///      &lt;target id=&quot;FY_OLUMSUZLUK_mA&quot; / [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string morphotactics {
            get {
                return ResourceManager.GetString("morphotactics", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///
        ///&lt;!DOCTYPE orthography SYSTEM &quot;../orthography.dtd&quot;&gt;
        ///
        ///&lt;orthography lang=&quot;Tr-TR&quot;&gt;
        ///
        ///  &lt;alphabet&gt;
        ///    &lt;consonants&gt;bcçdfgğhjklmnprsştvyýzDCSKYÇP&lt;/consonants&gt;
        ///    &lt;vowels&gt;áaâeéıîioóöúûuüUAI&lt;/vowels&gt;
        ///  &lt;/alphabet&gt;
        ///
        ///
        ///  &lt;!-- operandOne ve operandTwo string tipinde --&gt;
        ///
        ///  &lt;rules&gt;
        ///    &lt;rule id=&quot;DONUSUM_A&quot; phase=&quot;2&quot;&gt;
        ///      &lt;description&gt;Önceki ekin son sesli harfi kalın ise A =&gt; a değilse A =&gt; e &lt;/description&gt;
        ///      &lt;transformation morpheme=&quot;This&quot; action=&quot;Replace&quot;  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string orthography {
            get {
                return ResourceManager.GetString("orthography", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to root	surfaces	lex	active	Id	flags	rules
        ///gel				FIIL	fiil	
        ///git	gid			FIIL	fiil, genis_Ar	YUMUSAMA_td, 
        ///kalem				ISIM	isim	
        ///kitap	kitab			ISIM	isim	YUMUSAMA_pb
        ///bugün				ISIM	isim, zaman	ZAMAN_kü
        ///.
        /// </summary>
        internal static string root {
            get {
                return ResourceManager.GetString("root", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to id	lexicalForm	type	Grup	flags	rules	surfaces	Örnekler
        ///IC_COGUL_lAr	lAr	I			DONUSUM_A, 	lar, ler	kitaplar, kalemler
        ///IC_SAHIPLIK_BEN_(U)m	Um	I	ISIM_SAHIPLIK		DONUSUM_U, DUSME_UNLU, 	ım, im, um, üm, m 	kalemim, kitabım, köyüm, okulum, günlüğüm, masam
        ///IC_SAHIPLIK_SEN_(U)n	Un	I	ISIM_SAHIPLIK		DONUSUM_U, DUSME_UNLU, 	ın, in, un, ün, n	kalemin, kitabın, köyün, okulun, günlüğün, masan
        ///FC_ZAMAN_GECMIS_DU	DU	D	FIIL_ZAMAN		DONUSUM_D, DONUSUM_U, 	dı, di, du, dü, tı, ti, tu, tü	sardı, geldi, sordu, gördü, gitti, ka [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string suffix {
            get {
                return ResourceManager.GetString("suffix", resourceCulture);
            }
        }
    }
}