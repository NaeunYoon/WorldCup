// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:True,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9614,x:32719,y:32712,varname:node_9614,prsc:2|diff-8101-OUT,spec-3093-OUT,gloss-5886-OUT,normal-3910-OUT,alpha-9781-OUT,refract-9401-OUT;n:type:ShaderForge.SFN_Lerp,id:8101,x:32498,y:32688,varname:node_8101,prsc:2|A-2224-RGB,B-2874-RGB,T-7299-OUT;n:type:ShaderForge.SFN_Tex2d,id:2224,x:32157,y:32315,ptovrint:True,ptlb:Water Texture A,ptin:_MainTexture,varname:_MainTexture,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:2,isnm:False|UVIN-5537-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:2874,x:32129,y:32549,ptovrint:False,ptlb:Water Texture B,ptin:_WaterTextureB,varname:_WaterTextureB,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-3278-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:64,x:32085,y:32783,ptovrint:True,ptlb:Mask,ptin:_DetailMask,varname:_DetailMask,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-5537-UVOUT;n:type:ShaderForge.SFN_SwitchProperty,id:7299,x:32275,y:32800,ptovrint:False,ptlb:Use Main Tex Alpha,ptin:_UseMainTexAlpha,varname:_UseMainTexAlpha,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-64-R,B-2224-A;n:type:ShaderForge.SFN_Tex2d,id:2325,x:31949,y:32333,ptovrint:False,ptlb:Water A Gloss,ptin:_WaterAGloss,varname:_WaterAGloss,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-5537-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:1360,x:31912,y:32573,ptovrint:False,ptlb:Water B Gloss,ptin:_WaterBGloss,varname:_WaterBGloss,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-3278-UVOUT;n:type:ShaderForge.SFN_Lerp,id:9597,x:32484,y:32874,varname:node_9597,prsc:2|A-2325-R,B-1360-R,T-7299-OUT;n:type:ShaderForge.SFN_Multiply,id:5886,x:32473,y:33011,varname:node_5886,prsc:2|A-9597-OUT,B-2696-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2696,x:32473,y:33158,ptovrint:False,ptlb:Gloss,ptin:_Gloss,varname:_Gloss,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Vector1,id:3093,x:32484,y:32818,varname:node_3093,prsc:2,v1:0;n:type:ShaderForge.SFN_Panner,id:5537,x:31556,y:32387,varname:node_5537,prsc:2,spu:1,spv:1|UVIN-9747-UVOUT,DIST-1476-OUT;n:type:ShaderForge.SFN_Panner,id:3278,x:31572,y:32789,varname:node_3278,prsc:2,spu:1,spv:1|UVIN-9747-UVOUT,DIST-1691-OUT;n:type:ShaderForge.SFN_TexCoord,id:9747,x:31218,y:32438,varname:node_9747,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_ValueProperty,id:3152,x:30932,y:32707,ptovrint:False,ptlb:Velocity A,ptin:_VelocityA,varname:_VelocityA,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_ValueProperty,id:9097,x:31204,y:32907,ptovrint:False,ptlb:Velocity B,ptin:_VelocityB,varname:_VelocityB,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.2;n:type:ShaderForge.SFN_Tex2d,id:1167,x:31843,y:32915,ptovrint:False,ptlb:Normal A,ptin:_NormalA,varname:_NormalA,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:True|UVIN-5537-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:2996,x:31843,y:33153,ptovrint:False,ptlb:Normal B,ptin:_NormalB,varname:_NormalB,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:True|UVIN-3278-UVOUT;n:type:ShaderForge.SFN_Lerp,id:988,x:32048,y:33042,varname:node_988,prsc:2|A-1167-RGB,B-2996-RGB,T-7299-OUT;n:type:ShaderForge.SFN_Lerp,id:3910,x:32220,y:33042,varname:node_3910,prsc:2|A-988-OUT,B-7923-OUT,T-7507-OUT;n:type:ShaderForge.SFN_Vector3,id:7923,x:32048,y:33172,varname:node_7923,prsc:2,v1:0,v2:0,v3:1;n:type:ShaderForge.SFN_ValueProperty,id:7507,x:32048,y:33319,ptovrint:False,ptlb:Bump Smooth,ptin:_BumpSmooth,varname:_BumpSmooth,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ComponentMask,id:7318,x:32484,y:33338,varname:node_7318,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-3910-OUT;n:type:ShaderForge.SFN_Multiply,id:9401,x:32688,y:33291,varname:node_9401,prsc:2|A-7318-OUT,B-5992-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5992,x:32562,y:33544,ptovrint:False,ptlb:Refraction,ptin:_Refraction,varname:_Refraction,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:2961,x:32665,y:32440,varname:node_2961,prsc:2|A-7299-OUT,B-9105-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9105,x:32665,y:32578,ptovrint:False,ptlb:Opacity,ptin:_Opacity,varname:_Opacity,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Clamp01,id:9781,x:32840,y:32510,varname:node_9781,prsc:2|IN-8602-OUT;n:type:ShaderForge.SFN_Time,id:3322,x:31147,y:33154,varname:node_3322,prsc:2;n:type:ShaderForge.SFN_Multiply,id:1691,x:31390,y:32846,varname:node_1691,prsc:2|A-9097-OUT,B-7452-OUT;n:type:ShaderForge.SFN_Multiply,id:1476,x:31390,y:32717,varname:node_1476,prsc:2|A-3152-OUT,B-3322-T;n:type:ShaderForge.SFN_Sin,id:8844,x:31381,y:33331,varname:node_8844,prsc:2|IN-3322-TSL;n:type:ShaderForge.SFN_Add,id:7452,x:31381,y:33154,varname:node_7452,prsc:2|A-3322-T,B-8844-OUT;n:type:ShaderForge.SFN_Depth,id:8104,x:32447,y:32267,varname:node_8104,prsc:2;n:type:ShaderForge.SFN_Multiply,id:2484,x:32749,y:32255,varname:node_2484,prsc:2|A-8104-OUT,B-4498-OUT,C-610-OUT;n:type:ShaderForge.SFN_ValueProperty,id:4498,x:32582,y:32200,ptovrint:False,ptlb:Depth Focus,ptin:_DepthFocus,varname:_DepthFocus,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Vector1,id:610,x:32582,y:32321,varname:node_610,prsc:2,v1:0.1;n:type:ShaderForge.SFN_Add,id:8602,x:32840,y:32386,varname:node_8602,prsc:2|A-2484-OUT,B-2961-OUT;proporder:2224-2874-64-7299-2325-1360-2696-3152-9097-1167-2996-7507-5992-9105-4498;pass:END;sub:END;*/

Shader "DLNK Shaders/Advanced/WaterFx" {
    Properties {
        _MainTexture ("Water Texture A", 2D) = "black" {}
        _WaterTextureB ("Water Texture B", 2D) = "white" {}
        _DetailMask ("Mask", 2D) = "white" {}
        [MaterialToggle] _UseMainTexAlpha ("Use Main Tex Alpha", Float ) = 0
        _WaterAGloss ("Water A Gloss", 2D) = "white" {}
        _WaterBGloss ("Water B Gloss", 2D) = "white" {}
        _Gloss ("Gloss", Float ) = 1
        _VelocityA ("Velocity A", Float ) = 0.1
        _VelocityB ("Velocity B", Float ) = 0.2
        _NormalA ("Normal A", 2D) = "bump" {}
        _NormalB ("Normal B", 2D) = "bump" {}
        _BumpSmooth ("Bump Smooth", Float ) = 0
        _Refraction ("Refraction", Float ) = 1
        _Opacity ("Opacity", Float ) = 1
        _DepthFocus ("Depth Focus", Float ) = 1
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        LOD 200
        GrabPass{ }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone ps4 psp2 n3ds wiiu 
            #pragma target 3.0
            uniform sampler2D _GrabTexture;
            uniform sampler2D _MainTexture; uniform float4 _MainTexture_ST;
            uniform sampler2D _WaterTextureB; uniform float4 _WaterTextureB_ST;
            uniform sampler2D _DetailMask; uniform float4 _DetailMask_ST;
            uniform fixed _UseMainTexAlpha;
            uniform sampler2D _WaterAGloss; uniform float4 _WaterAGloss_ST;
            uniform sampler2D _WaterBGloss; uniform float4 _WaterBGloss_ST;
            uniform float _Gloss;
            uniform float _VelocityA;
            uniform float _VelocityB;
            uniform sampler2D _NormalA; uniform float4 _NormalA_ST;
            uniform sampler2D _NormalB; uniform float4 _NormalB_ST;
            uniform float _BumpSmooth;
            uniform float _Refraction;
            uniform float _Opacity;
            uniform float _DepthFocus;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                float4 projPos : TEXCOORD7;
                UNITY_FOG_COORDS(8)
                #if defined(LIGHTMAP_ON) || defined(UNITY_SHOULD_SAMPLE_SH)
                    float4 ambientOrLightmapUV : TEXCOORD9;
                #endif
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                #ifdef LIGHTMAP_ON
                    o.ambientOrLightmapUV.xy = v.texcoord1.xy * unity_LightmapST.xy + unity_LightmapST.zw;
                    o.ambientOrLightmapUV.zw = 0;
                #endif
                #ifdef DYNAMICLIGHTMAP_ON
                    o.ambientOrLightmapUV.zw = v.texcoord2.xy * unity_DynamicLightmapST.xy + unity_DynamicLightmapST.zw;
                #endif
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 node_3322 = _Time;
                float2 node_5537 = (i.uv0+(_VelocityA*node_3322.g)*float2(1,1));
                float3 _NormalA_var = UnpackNormal(tex2D(_NormalA,TRANSFORM_TEX(node_5537, _NormalA)));
                float2 node_3278 = (i.uv0+(_VelocityB*(node_3322.g+sin(node_3322.r)))*float2(1,1));
                float3 _NormalB_var = UnpackNormal(tex2D(_NormalB,TRANSFORM_TEX(node_3278, _NormalB)));
                float4 _DetailMask_var = tex2D(_DetailMask,TRANSFORM_TEX(node_5537, _DetailMask));
                float4 _MainTexture_var = tex2D(_MainTexture,TRANSFORM_TEX(node_5537, _MainTexture));
                float _UseMainTexAlpha_var = lerp( _DetailMask_var.r, _MainTexture_var.a, _UseMainTexAlpha );
                float3 node_3910 = lerp(lerp(_NormalA_var.rgb,_NormalB_var.rgb,_UseMainTexAlpha_var),float3(0,0,1),_BumpSmooth);
                float3 normalLocal = node_3910;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                float2 sceneUVs = (i.projPos.xy / i.projPos.w) + (node_3910.rg*_Refraction);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float4 _WaterAGloss_var = tex2D(_WaterAGloss,TRANSFORM_TEX(node_5537, _WaterAGloss));
                float4 _WaterBGloss_var = tex2D(_WaterBGloss,TRANSFORM_TEX(node_3278, _WaterBGloss));
                float gloss = (lerp(_WaterAGloss_var.r,_WaterBGloss_var.r,_UseMainTexAlpha_var)*_Gloss);
                float perceptualRoughness = 1.0 - (lerp(_WaterAGloss_var.r,_WaterBGloss_var.r,_UseMainTexAlpha_var)*_Gloss);
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                #if defined(LIGHTMAP_ON) || defined(DYNAMICLIGHTMAP_ON)
                    d.ambient = 0;
                    d.lightmapUV = i.ambientOrLightmapUV;
                #else
                    d.ambient = i.ambientOrLightmapUV;
                #endif
                #if UNITY_SPECCUBE_BLENDING || UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMin[0] = unity_SpecCube0_BoxMin;
                    d.boxMin[1] = unity_SpecCube1_BoxMin;
                #endif
                #if UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMax[0] = unity_SpecCube0_BoxMax;
                    d.boxMax[1] = unity_SpecCube1_BoxMax;
                    d.probePosition[0] = unity_SpecCube0_ProbePosition;
                    d.probePosition[1] = unity_SpecCube1_ProbePosition;
                #endif
                d.probeHDR[0] = unity_SpecCube0_HDR;
                d.probeHDR[1] = unity_SpecCube1_HDR;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = 0.0;
                float specularMonochrome;
                float4 _WaterTextureB_var = tex2D(_WaterTextureB,TRANSFORM_TEX(node_3278, _WaterTextureB));
                float3 diffuseColor = lerp(_MainTexture_var.rgb,_WaterTextureB_var.rgb,_UseMainTexAlpha_var); // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                half surfaceReduction;
                #ifdef UNITY_COLORSPACE_GAMMA
                    surfaceReduction = 1.0-0.28*roughness*perceptualRoughness;
                #else
                    surfaceReduction = 1.0/(roughness*roughness + 1.0);
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                half grazingTerm = saturate( gloss + specularMonochrome );
                float3 indirectSpecular = (gi.indirect.specular);
                indirectSpecular *= FresnelLerp (specularColor, grazingTerm, NdotV);
                indirectSpecular *= surfaceReduction;
                float3 specular = (directSpecular + indirectSpecular);
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += gi.indirect.diffuse;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(lerp(sceneColor.rgb, finalColor,saturate(((partZ*_DepthFocus*0.1)+(_UseMainTexAlpha_var*_Opacity)))),1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone ps4 psp2 n3ds wiiu 
            #pragma target 3.0
            uniform sampler2D _GrabTexture;
            uniform sampler2D _MainTexture; uniform float4 _MainTexture_ST;
            uniform sampler2D _WaterTextureB; uniform float4 _WaterTextureB_ST;
            uniform sampler2D _DetailMask; uniform float4 _DetailMask_ST;
            uniform fixed _UseMainTexAlpha;
            uniform sampler2D _WaterAGloss; uniform float4 _WaterAGloss_ST;
            uniform sampler2D _WaterBGloss; uniform float4 _WaterBGloss_ST;
            uniform float _Gloss;
            uniform float _VelocityA;
            uniform float _VelocityB;
            uniform sampler2D _NormalA; uniform float4 _NormalA_ST;
            uniform sampler2D _NormalB; uniform float4 _NormalB_ST;
            uniform float _BumpSmooth;
            uniform float _Refraction;
            uniform float _Opacity;
            uniform float _DepthFocus;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                float4 projPos : TEXCOORD7;
                LIGHTING_COORDS(8,9)
                UNITY_FOG_COORDS(10)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 node_3322 = _Time;
                float2 node_5537 = (i.uv0+(_VelocityA*node_3322.g)*float2(1,1));
                float3 _NormalA_var = UnpackNormal(tex2D(_NormalA,TRANSFORM_TEX(node_5537, _NormalA)));
                float2 node_3278 = (i.uv0+(_VelocityB*(node_3322.g+sin(node_3322.r)))*float2(1,1));
                float3 _NormalB_var = UnpackNormal(tex2D(_NormalB,TRANSFORM_TEX(node_3278, _NormalB)));
                float4 _DetailMask_var = tex2D(_DetailMask,TRANSFORM_TEX(node_5537, _DetailMask));
                float4 _MainTexture_var = tex2D(_MainTexture,TRANSFORM_TEX(node_5537, _MainTexture));
                float _UseMainTexAlpha_var = lerp( _DetailMask_var.r, _MainTexture_var.a, _UseMainTexAlpha );
                float3 node_3910 = lerp(lerp(_NormalA_var.rgb,_NormalB_var.rgb,_UseMainTexAlpha_var),float3(0,0,1),_BumpSmooth);
                float3 normalLocal = node_3910;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                float2 sceneUVs = (i.projPos.xy / i.projPos.w) + (node_3910.rg*_Refraction);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float4 _WaterAGloss_var = tex2D(_WaterAGloss,TRANSFORM_TEX(node_5537, _WaterAGloss));
                float4 _WaterBGloss_var = tex2D(_WaterBGloss,TRANSFORM_TEX(node_3278, _WaterBGloss));
                float gloss = (lerp(_WaterAGloss_var.r,_WaterBGloss_var.r,_UseMainTexAlpha_var)*_Gloss);
                float perceptualRoughness = 1.0 - (lerp(_WaterAGloss_var.r,_WaterBGloss_var.r,_UseMainTexAlpha_var)*_Gloss);
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = 0.0;
                float specularMonochrome;
                float4 _WaterTextureB_var = tex2D(_WaterTextureB,TRANSFORM_TEX(node_3278, _WaterTextureB));
                float3 diffuseColor = lerp(_MainTexture_var.rgb,_WaterTextureB_var.rgb,_UseMainTexAlpha_var); // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor * saturate(((partZ*_DepthFocus*0.1)+(_UseMainTexAlpha_var*_Opacity))),0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "Meta"
            Tags {
                "LightMode"="Meta"
            }
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_META 1
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone ps4 psp2 n3ds wiiu 
            #pragma target 3.0
            uniform sampler2D _MainTexture; uniform float4 _MainTexture_ST;
            uniform sampler2D _WaterTextureB; uniform float4 _WaterTextureB_ST;
            uniform sampler2D _DetailMask; uniform float4 _DetailMask_ST;
            uniform fixed _UseMainTexAlpha;
            uniform sampler2D _WaterAGloss; uniform float4 _WaterAGloss_ST;
            uniform sampler2D _WaterBGloss; uniform float4 _WaterBGloss_ST;
            uniform float _Gloss;
            uniform float _VelocityA;
            uniform float _VelocityB;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                return o;
            }
            float4 frag(VertexOutput i) : SV_Target {
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                o.Emission = 0;
                
                float4 node_3322 = _Time;
                float2 node_5537 = (i.uv0+(_VelocityA*node_3322.g)*float2(1,1));
                float4 _MainTexture_var = tex2D(_MainTexture,TRANSFORM_TEX(node_5537, _MainTexture));
                float2 node_3278 = (i.uv0+(_VelocityB*(node_3322.g+sin(node_3322.r)))*float2(1,1));
                float4 _WaterTextureB_var = tex2D(_WaterTextureB,TRANSFORM_TEX(node_3278, _WaterTextureB));
                float4 _DetailMask_var = tex2D(_DetailMask,TRANSFORM_TEX(node_5537, _DetailMask));
                float _UseMainTexAlpha_var = lerp( _DetailMask_var.r, _MainTexture_var.a, _UseMainTexAlpha );
                float3 diffColor = lerp(_MainTexture_var.rgb,_WaterTextureB_var.rgb,_UseMainTexAlpha_var);
                float specularMonochrome;
                float3 specColor;
                diffColor = DiffuseAndSpecularFromMetallic( diffColor, 0.0, specColor, specularMonochrome );
                float4 _WaterAGloss_var = tex2D(_WaterAGloss,TRANSFORM_TEX(node_5537, _WaterAGloss));
                float4 _WaterBGloss_var = tex2D(_WaterBGloss,TRANSFORM_TEX(node_3278, _WaterBGloss));
                float roughness = 1.0 - (lerp(_WaterAGloss_var.r,_WaterBGloss_var.r,_UseMainTexAlpha_var)*_Gloss);
                o.Albedo = diffColor + specColor * roughness * roughness * 0.5;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
