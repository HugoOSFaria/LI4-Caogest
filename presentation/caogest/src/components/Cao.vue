<template>
    <div>           
        <v-card flat height = "200"></v-card>
        <v-container fluid>
            <v-row class = "align-center justify-center">
                <v-col cols = "4">
                    <v-card flat class = "mx-auto" height = "800" width = "900"> 
                         <v-img height = "800" width = "800" :src="require(`@/assets/${getPath(cao)}`)"></v-img> 
                    </v-card>
                </v-col>

                <v-col cols = "5">
                    <v-card color = "brown lighten-5" height = "800" width = "1000" tile>
                        <v-card flat color = "brown lighten-5" height = "40"></v-card>
                        <v-row class="ml-8">
                            <p 
                                class = " display-1 font-weight-bold" 
                                color = "grey"
                            > Nome: 
                                <span 
                                    class = "display-1 font-weight-regular "
                                >{{cao.nome}}</span>
                            </p> 
                            </v-row>
                            <v-card 
                                flat 
                                color = "brown lighten-5 "
                                height = "20"
                            ></v-card>
                            <v-row class="ml-8">
                                <p 
                                    class = " display-1 font-weight-bold" 
                                    color = "grey"
                                > Raça: 
                                    <span 
                                        class = "display-1 font-weight-regular "
                                    >{{cao.raca}}</span>
                                </p> 
                            </v-row>
                            <v-card 
                                flat 
                                color = "brown lighten-5" 
                                height = "20"
                            ></v-card>                                       
                            <v-row class="ml-8">
                                <p 
                                    class = " display-1 font-weight-bold" 
                                    color = "grey"
                                > Idade: 
                                    <span 
                                        class = "healine font-weight-regular "
                                    >{{cao.idade}}</span>
                                </p> 
                            </v-row>
                            <v-card 
                                flat 
                                color = "brown lighten-5" 
                                height = "20"
                            ></v-card>
                            <v-row class="ml-8">
                                <p 
                                    class = " display-1 font-weight-bold" 
                                    color = "grey"
                                > Cor: 
                                    <span 
                                        class = "healine font-weight-regular "
                                    >{{cao.cor}}</span>
                                </p> 
                            </v-row>
                            <v-card 
                                flat 
                                color = "brown lighten-5" 
                                height = "20"
                            ></v-card>                                    
                            <v-row class="ml-8">
                                <p 
                                    class = " display-1 font-weight-bold" 
                                    color = "grey"
                                > Porte: 
                                    <span 
                                        class = "display-1 font-weight-regular "
                                    >{{cao.porte}}</span>
                                </p> 
                            </v-row>
                            <v-card 
                                flat 
                                color = "brown lighten-5" 
                                height = "20"
                            ></v-card>
                            <v-row class="ml-8">
                                <p 
                                    class = " display-1 font-weight-bold" 
                                    color = "grey"
                                > Sexo: 
                                    <span 
                                        class = "display-1 font-weight-regular "
                                    >{{cao.sexo}}</span>
                                </p> 
                            </v-row>
                            <v-card 
                                flat 
                                color = "brown lighten-5" 
                                height = "20"
                            ></v-card>                                        
                            <v-row class="ml-8">
                            <p 
                                class = " display-1 font-weight-bold" 
                                color = "grey"
                            > Esterilizado: 
                                <span 
                                    class = "display-1 font-weight-regular "
                                >{{cao.esterilizacao}}
                                </span>
                            </p> 
                            </v-row>
                            <v-card 
                                flat   
                                color = "brown lighten-5" 
                                height = "20"
                            ></v-card>
                            <v-row class="ml-8">
                                <p 
                                    class = " display-1 font-weight-bold" 
                                    color = "grey"
                                > Descrição: 
                                    <span 
                                        class = "display-1 font-weight-regular "
                                    >{{cao.descricao}}</span>
                                </p> 
                            </v-row>
                            <v-card 
                                flat 
                                color = "brown lighten-5" 
                                height = "20"
                            ></v-card>   
                            <v-row class="ml-8">
                                <p class = " display-1 font-weight-bold" 
                                    color = "grey"
                                > Canil: 
                                    <span 
                                        class = "display-1 font-weight-regular "
                                    >{{cao.nome_canil}}</span>
                                </p> 
                            </v-row>
                        </v-card>
                    </v-col>
                </v-row>
                <v-row justify = "end">
                    <v-col cols = "12" md = "10">
                        <v-row justify= "start">
                             <v-btn color = "red darken-3" dark x-large class = "headline" @click="alert = !alert"> Remover Cão</v-btn>
                                    <v-alert
                                        :value="alert"
                                        color="red"
                                        prominent
                                        dark
                                        transition="scale-transition"
                                        type = "error"
                                        text
                                    >
                                    <v-row align="center">
                                        <v-col class="grow">Tem a certeza de que pretende remover este cão? Todos os dados serão perdidos, pelo que é uma ação irreversível.</v-col>
                                        <v-col class="shrink">
                                            <v-btn @click="removeCao(cao)">Remover</v-btn>
                                        </v-col>
                                    </v-row>
                                </v-alert>
                        </v-row>
                    </v-col>
                </v-row>
            </v-container>
    </div>
</template>

<script>
import axios from 'axios'
const lhost = require("@/config/global").host;


export default {
    name: "Dog",
    props:['id', 'id2'],

    data: () => ({   
        alert: false, 
        fab:false,  
        fotos: [],
        favoritos:[],
        cao:[],

    }),
    methods:{
        getPath: function(e) {
           return e.fotos[0].path;
        },
        removeCao: async function(cao) {
            try{ 
                var resposta = 
                await axios.put(lhost + "/api/Caes/" + this.id2 , {
                    idCao:parseInt(this.id2),
                    nome:cao.nome,
                    raca:cao.raca,
                    idade:cao.idade,
                    sexo:cao.sexo,
                    cor:cao.cor,
                    porte:cao.porte,
                    esterilizacao:cao.esterilizacao,
                    descricao:cao.descricao,
                    estado:"Apagado",
                    canil_user_email:this.id,
                    fotos: cao.fotos,
                });
                console.log(JSON.stringify(resposta.data));
                this.$router.push("/pagina/canil/" + this.id);
                this.dialog=false;
            }
            catch(e){
                console.log("erro: " + e); 
            }
        },
    },
    created: async function(){
        try {
            let response = await axios.get(lhost + "/api/Caes/" + this.id2);
            this.cao = response.data;

            let resposta = await axios.get(lhost + "/api/Favoritos/" + this.id); 
            this.favoritos = resposta.data; 

            this.ready = true;
        } 
        catch (e) {
        return e;
        }
    }, 
    computed: {
        favoritado: function(){
            let self=this;
            return this.favoritos.filter(function (fav){
                return (fav.idCao == self.id2)
            })
        }, 
        lista: function(){
            return (this.favoritado.length) ? true : false;
        }
    }  

}
</script>

                
                           