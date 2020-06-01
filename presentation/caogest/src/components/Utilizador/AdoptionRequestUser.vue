<template>
  <div id="adoptionrequest">
    <v-card flat height="200" color="white"></v-card>
    <p class="my-5 display-2 font-weight-bold text-center">Pedidos de Adoção</p>
    <v-card flat height="40" color="white"></v-card>

    <v-container class="my-5">

         <v-layout row class="mb-1"> 
            <v-tooltip top>
                <template v-slot:activator="{ on }">
                    <v-btn class = "ma-2" text @click="sortBy('utilizador_user_email')" v-on="on">
                        <v-icon left small>person</v-icon>    
                        <span class = "caption text-lowercase">Por nome de utilizador</span>
                    </v-btn>  
                </template>
                <span>Ordenar pedidos por nome de utilizador</span> 
            </v-tooltip>

            <v-tooltip top>
                <template v-slot:activator="{ on }">
                    <v-btn class = "ma-2" text @click="sortBy('nome_Canil')" v-on="on">
                        <v-icon left small>pets</v-icon>    
                        <span class = "caption text-lowercase">Por canil</span>
                    </v-btn>  
                </template>
                <span>Ordenar pedidos por nome de canil</span> 
            </v-tooltip>

            <v-tooltip top>    
              <template v-slot:activator="{ on }">
                <v-btn class = "ma-2" text @click="sortByData('data')" v-on="on">
                  <v-icon left small>today</v-icon>    
                  <span class = "caption text-lowercase">Por data</span>
                </v-btn> 
              </template>
              <span>Ordenar pedidos por data de submissão</span>
            </v-tooltip>  
        </v-layout>

      <v-card flat height = "100"></v-card>
      <v-card class = "mx-auto" height = "80" width="2000" flat color = "brown lighten-5" v-if="this.pedidos.length === 0"> 
        <v-card-title class = "display-1 text-center justify-center"> Não existem pedidos de adoção </v-card-title>
        
      </v-card>
      <v-card v-else flat v-for="pedido in pedidos" :key="pedido.nPedido">
        <v-layout row wrap :class="`pa-7 pedido ${pedido.estado}`">
          <v-flex xs8 md2>
            <div class="caption grey--text">Nome Cão</div>
            <div class=" headline">{{ pedido.nome_Cao }}</div>
          </v-flex>
          <v-flex xs12 md5>
            <div class="caption grey--text">Nome Canil</div>
            <div class=" headline">{{ pedido.nome_Canil }}</div>
          </v-flex>
          <v-flex xs8 md2>
            <div class="caption grey--text">Data de Submissão</div>
            <div class="method headline">{{date(pedido.data)}}</div>
          </v-flex>
          <v-flex xs1 md1>
               <v-chip :color="project_status(pedido.estado)" class="black--text caption my-2" @click="getPedidos(pedido)">{{pedido.estado}}</v-chip> 
            <div>
            </div>
          </v-flex>
        </v-layout>
        <v-divider></v-divider>
      </v-card>
      <v-dialog 
            v-model="dialog" 
            fullscreen 
            hide-overlay 
            transition="dialog-bottom-transition"
        >                                                                              
            <v-card 
                class = "ma-2" 
                flat
            >
            <v-toolbar 
                height = "100" 
                color="deep-orange lighten-4"
            >
                <v-btn icon @click="dialog = false">
                    <v-icon>mdi-close</v-icon>
                </v-btn>
                <v-toolbar-title >Fechar</v-toolbar-title>
            </v-toolbar>
                                                        
            <v-card 
                color = "white" 
                height = "150" 
                flat
            ></v-card>
                                        
            <v-card flat height = "100" color = "brown lighten-5">
            <v-row>
                <v-card-text class = "display-2 black--text text-center">
                    {{individual.nome_Utilizador}} 
                    <v-icon>pets</v-icon> 
                    {{individual.cao_idCao}}
                </v-card-text>
            </v-row>
        </v-card>
        <v-card flat height = "50"></v-card>
        <v-card flat class="ma-12" max-width="3000" fluid>
            <v-row>
                <v-col>
                    <v-card flat color = "white" class = "mx-auto" height = "800" width = "900"> 
                         <v-img height = "800" width = "800" src='@/assets/example.jpg'></v-img> 
                    </v-card>
                </v-col>
                <v-col>
                    <v-card flat>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Nome Completo: 
                                <span class = "display-1 font-weight-regular ">{{individual.nome_Utilizador}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Nome Cão: 
                                <span class = "display-1 font-weight-regular ">{{individual.cao_idCao}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Número do Cartão de Cidadão: 
                                <span class = "display-1 font-weight-regular ">{{individual.cc}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Tipo de Moradia: 
                                <span class = "display-1 font-weight-regular ">{{individual.tipoMoradia}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Espaço exterior ou equivalente: 
                                <span class = "display-1 font-weight-regular ">{{individual.exterior}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> A sua habitação é: 
                                <span class = "display-1 font-weight-regular ">{{individual.habitacao}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Em caso de alugada ou condomínio, tem permissão para ter animais: 
                                <span class = "display-1 font-weight-regular ">{{individual.permissao}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Pretende um cão para: 
                                <span class = "display-1 font-weight-regular ">{{individual.motivo}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Em caso de ausência para férias, trabalho ou outra, o seu cão:
                                <span class = "display-1 font-weight-regular ">{{individual.ausencia}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Tem alguém alérgico a cães na família: 
                                <span class = "display-1 font-weight-regular ">{{individual.alergia}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> É dono de mais algum animal: 
                                <span class = "display-1 font-weight-regular ">{{individual.donoAnimal}}</span>
                            </p>
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Se sim, quais: 
                                <span class = "display-1 font-weight-regular ">{{individual.descAnimais}}</span>
                            </p> 
                        </v-row>
                        <v-card flat color = "white" height = "40"></v-card>
                        <v-row>
                            <p class = " display-1 font-weight-bold" color = "grey"> Comprovativo de Morada: 
                                <span class = "display-1 font-weight-regular ">{{individual.comprovativo}}</span>
                            </p> 
                        </v-row>
                    </v-card>
                </v-col>
            </v-row>
        </v-card>
            </v-card>
        </v-dialog>
      <v-btn
            v-scroll="onScroll"
            x-large
            v-show="fab"
            fab
            depressed
            fixed
            bottom
            right
            class = "ma-6"
            color="deep-orange lighten-4"
            @click="toTop"
        >
            <v-icon>keyboard_arrow_up</v-icon>
        </v-btn>
    </v-container>
  </div>
</template>

<script>
import moment from 'moment/moment';
import axios from 'axios'
const lhost = require("@/config/global").host;

export default {
  data() {
    return {
      pedidos: [],
      individual: {},
      dialog:false, 
      fab:false,
      utilizador_user_email:"",
      cao_idCao:"", 
      cc:"", 
      tipoMoradia:"", 
      exterior:"", 
      habitacao:"", 
      permissao:"", 
      motivo:"", 
      ausencia:"", 
      alergia:"", 
      donoAnimal:"", 
      descAnimais:"", 
      comprovativo:"", 
    };
  },
  name: 'AdoptionRequest',    
  props: ['id'], 
  methods: {
    sortBy(prop){
          this.pedidos.sort((a,b) => a[prop] < b[prop] ? -1 : 1)
    },
    sortByData(prop){
          this.pedidos.sort((a,b) => a[prop] < b[prop] ? 1 : -1)
    },

    project_status(estado) {
        if (estado == "Aceite") 
          return "#C5E1A5";
        else if (estado == "Pendente") 
          return "#FFE082";
        else if (estado == "Expirado")
          return "#B39DDB";
        return "#EF9A9A";
    }, 
    
    getPedidos: async function(pedido){
      try{ 
        var resposta = 
        await axios.get(lhost + "/api/Adocoes/" + pedido.nPedido);
        this.individual = resposta.data;
        this.dialog = true;
      }
      catch (e) {
        return e;
      }
    },
    pedidoadocao: function(pedido){
      this.dialog = true;
      this.utilizador_user_email = pedido.utilizador_user_email;
      this.cao_idCao = pedido.cao_idCao;
      this.cc = pedido.cc;
      this.tipoMoradia = pedido.tipoMoradia;
      this.exterior = pedido.exterior;
      this.habitacao = pedido.habitacao;
      this.permissao = pedido.permissao;
      this.motivo = pedido.motivo;
      this.ausencia = pedido.ausencia; 
      this.alergia = pedido.alergia; 
      this.donoAnimal = pedido.donoAnimal; 
      this.descAnimais = pedido.descAnimais; 
      this.comprovativo = pedido.comprovativo;
    }, 
    date: function (date) {
      return moment(date).locale("pt").format('LL');
    },
    onScroll (e) {
      if (typeof window === 'undefined') return
      const top = window.pageYOffset ||   e.target.scrollTop || 0
      this.fab = top > 20
    },
    toTop () {
      this.$vuetify.goTo(0)
    },
  },
  created: async function(){
    try {
      let response = await axios.get(lhost + "/api/AdocoesUtilizador/" + this.id);
      this.pedidos = response.data;
      this.ready = true;
    } 
    catch (e) {
      return e;
    }
  }    
};
</script>

<style>
.pedido.Aceite {
  border-left: 4px solid #C5E1A5;
}

.pedido.Pendente {
  border-left: 4px solid #FFE082;
}

.pedido.Expirado {
  border-left: 4px solid #B39DDB;
}

.pedido.Recusado {
    border-left: 4px solid #EF9A9A;
}

</style>

