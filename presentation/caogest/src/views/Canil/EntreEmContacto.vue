<template>
  <div id="entreemcontacto" class="entreemcontacto">
    <NavbarAdmin />
    <v-card>
      <v-img src="@/assets/entreemcontacto.png"></v-img>
    </v-card>
    <v-card flat height="150" color="white"></v-card>

    <v-container max-witdh="5000">
      <v-layout row class="mb-1"> 
            <v-tooltip top>
                <template v-slot:activator="{ on }">
                    <v-btn class = "ma-2" text @click="sortBy('data')" v-on="on">
                        <v-icon left small>schedule</v-icon>    
                        <span class = "caption text-lowercase">Por data</span>
                    </v-btn>  
                </template>
                <span>Ordenar mensagens por data</span> 
            </v-tooltip>
      </v-layout>
      <v-tabs
        centered
        v-model="tab"
        background-color="brown lighten-5"
        color="brown darken-5"
        height="100"
        grow
      >
        <v-tab>
          Caixa de Entrada
          <v-badge
            :content="messages"
            :value="messages"
            color="deep-orange darken-4"
            overlap
          >
            <v-icon right large>mdi-email</v-icon>
          </v-badge>
        </v-tab>
        <v-tab>
          Eliminadas
          <v-badge
            :content="deleted"
            :value="deleted"
            color="deep-orange darken-4"
            overlap
          >
            <v-icon right large>delete</v-icon>
          </v-badge>
        </v-tab>
        <v-tab>
          Enviadas
          <v-icon right large>send</v-icon>
        </v-tab>
      </v-tabs>
      <v-card max-witdh="5000" flat>
        <v-tabs-items v-model="tab">

          <v-tab-item>
            <v-list two-line color="brown lighten-5">
              <v-list-item-group
                v-model="selected"
                multiple
                active-class="brown--text"
              >
                <v-list-item
                  color="dark lighten-4"
                  v-for="obj in recebidas"
                  :key="obj.id"
                  @click="openDialog(obj)"
                >
                  <v-list-item-content>
                    <v-list-item-title
                      class="display-1"
                      v-text="obj.nome"
                    ></v-list-item-title>
                    <v-list-item-subtitle
                      class=" headline text--primary"
                      v-text="obj.motivo"
                    ></v-list-item-subtitle>
                  </v-list-item-content>
                  <v-list-item-action>
                  <v-list-item-action-text> {{date(obj.data)}}
                  </v-list-item-action-text>
                </v-list-item-action>
                <v-list-item-icon>
                  <v-icon :color="obj.estado == 'Não Lida' ? 'brown lighten-1' : 'grey'">chat_bubble</v-icon>
                </v-list-item-icon>
                </v-list-item>
              </v-list-item-group>
            </v-list>
          </v-tab-item>

          <v-tab-item>
            <v-list two-line color="brown lighten-5">
              <v-list-item
                color="dark lighten-4"
                v-for="obj in apagadas"
                :key="obj.id"
                @click="openApagadas(obj)"
              >
                <v-list-item-content>
                  <v-list-item-title
                    class="display-1"
                    v-text="obj.nome"
                  ></v-list-item-title>
                  <v-list-item-subtitle
                    class=" headline text--primary"
                    v-text="obj.motivo"
                  ></v-list-item-subtitle>
                </v-list-item-content>

                <v-list-item-action>
                  <v-list-item-action-text> {{date(obj.data)}}
                  </v-list-item-action-text>
                  <v-btn icon @click="recuperaMensagem(obj)">
                    <v-icon large color="grey">restore_from_trash</v-icon>
                  </v-btn>
                </v-list-item-action>
              </v-list-item>
            </v-list>
          </v-tab-item>
          
          <v-tab-item>
            <v-list two-line color="brown lighten-5">
              <v-list-item
                color="brown darken-4"
                v-for="obj in enviadas"
                :key="obj.id"
                @click="openEnviadas(obj)"
              >
                <v-list-item-content>
                  <v-list-item-title 
                    class="display-1" 
                    v-text="obj.nome"
                  ></v-list-item-title>

                  <v-list-item-subtitle
                    class=" headline text--primary"
                    v-text="obj.motivo"
                  ></v-list-item-subtitle>
                </v-list-item-content>

                <v-list-item-action>
                  <v-list-item-action-text> {{date(obj.data)}}
                  </v-list-item-action-text>
                  <v-btn icon>
                    <v-icon large color="grey">delete</v-icon>
                  </v-btn>
                </v-list-item-action>
              </v-list-item>
            </v-list>
          </v-tab-item>
        </v-tabs-items>
      </v-card>
    </v-container>

    <v-dialog v-model="dialog" max-width="1500">
      <v-card>
        <v-card-title class="display-2 ma-2 pt-12">{{
          this.motivo
        }}</v-card-title>

        <v-card-subtitle 
          class = "display-1 ma-2 pb-12"> 
          {{ this.nome }} 
          <p 
            class = "headline"> 
            {{this.user_email}} 
          </p>
        </v-card-subtitle>

        <v-card-text class = "headline ma-2"> {{ this.sugestoes }} </v-card-text>

        <v-card-actions>

          <v-btn
            color="red"
            outlined
            x-large
            class = "ma-4 "
            @click="apagaMensagem(this)"
          >
            Apagar
          </v-btn>

          <v-spacer></v-spacer>
          
          <v-btn
            color="brown darken-4"
            outlined
            x-large
            class = "ma-4"
            @click="dialog = false"
          >
            Fechar
          </v-btn>
        </v-card-actions>
      </v-card>
    </v-dialog>

    <v-dialog v-model="dialog2" max-width="1500">
      <v-card>
        <v-card-title class="display-2 ma-2 pt-12">{{
          this.motivo
        }}</v-card-title>

        <v-card-subtitle 
          class = "display-1 ma-2 pb-12"> 
          {{ this.nome }} 
          <p 
            class = "headline"> 
            {{this.user_email}} 
          </p>
        </v-card-subtitle>

        <v-card-text class = "headline ma-2"> {{ this.sugestoes }} </v-card-text>

        <v-card-actions>
          <v-spacer></v-spacer>
          
          <v-btn
            color="brown darken-4"
            outlined
            x-large
            class = "ma-4"
            @click="dialog2 = false"
          >
            Fechar
          </v-btn>
        </v-card-actions>
      </v-card>
    </v-dialog>

    <v-dialog v-model="dialog3" max-width="1500">
      <v-card>
        <v-card-title class="display-2 ma-2 pt-12">{{
          this.motivo
        }}</v-card-title>

        <v-card-subtitle 
          class = "display-1 ma-2 pb-12"> 
          {{ this.nome }} 
          <p 
            class = "headline"> 
            {{this.user_email}} 
          </p>
        </v-card-subtitle>

        <v-card-text class = "headline ma-2"> {{ this.sugestoes }} </v-card-text>

        <v-card-actions>
          <v-spacer></v-spacer>
          
          <v-btn
            color="brown darken-4"
            outlined
            x-large
            class = "ma-4"
            @click="dialog3 = false"
          >
            Fechar
          </v-btn>
        </v-card-actions>
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
    <Footer/>

  </div>
</template>

<script>

import NavbarAdmin from "@/components/NavbarFooter/NavbarKennel.vue";
import Footer from "@/components/NavbarFooter/FooterKennel.vue";
import moment from 'moment/moment';
import axios from 'axios'
const lhost = require("@/config/global").host;

export default {
  props: ["sugestao"],
  data() {
    return {
      fab:false,
      selected: [],
      dialog: false,
      dialog2:false, 
      dialog3:false, 
      sugestoesl: [],
      tab: null,
      messages:this.numero,
      deleted: 0,
      motivo: "",
      sugestoes: "",
      nome: "",
      estado: "",
      data: "",
      user_email: "",
      form:{
        sugestoes: "",
        estado: "Enviada",
        data: moment().format(),
      }
    };
  },
  methods: {
    openDialog: function(dados){
      this.motivo = dados.motivo;
      this.sugestoes = dados.sugestoes;
      this.nome = dados.nome;
      this.estado = dados.estado;
      this.data = dados.data;
      this.user_email = dados.user_email;
      this.id = dados.id;
      this.dialog = true;
      if(this.estado === 'Lida'){
        this.marcaNaoLida();
      }
      else{
        this.marcaLida();
      }
    },
    openApagadas: function(dados){
      this.motivo = dados.motivo;
      this.sugestoes = dados.sugestoes;
      this.nome = dados.nome;
      this.estado = dados.estado;
      this.data = dados.data;
      this.user_email = dados.user_email;
      this.id = dados.id;
      this.dialog2 = true;
    },
    openEnviadas: function(dados){
      this.motivo = dados.motivo;
      this.sugestoes = dados.sugestoes;
      this.nome = dados.nome;
      this.estado = dados.estado;
      this.data = dados.data;
      this.user_email = dados.user_email;
      this.id = dados.id;
      this.dialog3 = true;
    },
    date: function (date) {
      return moment(date).locale("pt").fromNow();
    },
    sortBy(prop){
          this.sugestoesl.sort((a,b) => a[prop] < b[prop] ? 1 : -1)
    },
    onScroll (e) {
      if (typeof window === 'undefined') return
      const top = window.pageYOffset ||   e.target.scrollTop || 0
      this.fab = top > 20
    },
    toTop () {
      this.$vuetify.goTo(0)
    },
    marcaLida: async function(){
      try{ 
        var resposta = 
        await axios.put(lhost + "/api/Sugestoes/" + this.id , {
          id:this.id, 
          motivo:this.motivo,
          sugestoes:this.sugestoes,
          nome:this.nome,
          estado:"Lida",
          data:this.data,
          user_email: this.user_email,
        });
        console.log(JSON.stringify(resposta.data));
        this.messages--;
      }
      catch(e){
        console.log("erro: " + e); 
      }
    },
    marcaNaoLida: async function(){
      try{ 
        var resposta = 
        await axios.put(lhost + "/api/Sugestoes/" + this.id , {
          id:this.id, 
          motivo:this.motivo,
          sugestoes:this.sugestoes,
          nome:this.nome,
          estado:"Não Lida",
          data:this.data,
          user_email: this.user_email,
        });
        console.log(JSON.stringify(resposta.data));
        this.messages++;
      }
      catch(e){
        console.log("erro: " + e); 
      }
    },
    apagaMensagem: async function(){
       try{ 
        var resposta = 
        await axios.put(lhost + "/api/Sugestoes/" + this.id , {
          id:this.id, 
          motivo:this.motivo,
          sugestoes:this.sugestoes,
          nome:this.nome,
          estado:"Apagada",
          data:this.data,
          user_email: this.user_email,
        });
        console.log(JSON.stringify(resposta.data));
      }
      catch(e){
        console.log("erro: " + e); 
      }
      this.dialog = false;
    },
    recuperaMensagem: async function(dados){
        this.motivo = dados.motivo;
        this.sugestoes = dados.sugestoes;
        this.nome = dados.nome;
        this.estado = dados.estado;
        this.data = dados.data;
        this.user_email = dados.user_email;
        this.id = dados.id;
        this.estado = dados.estado;
       try{ 
        var resposta = 
        await axios.put(lhost + "/api/Sugestoes/" + this.id , {
          id:this.id, 
          motivo:this.motivo,
          sugestoes:this.sugestoes,
          nome:this.nome,
          estado:"Lida",
          data:this.data,
          user_email: this.user_email,
        });
        console.log(JSON.stringify(resposta.data));
      }
      catch(e){
        console.log("erro: " + e); 
      }
    },
    enviaMensagem: async function(){
      try{
        var resposta = 
          await axios.post(lhost + "/api/Sugestoes", {
            user_email: this.user_email,
            nome: this.nome,
            motivo: this.motivo,
            sugestoes: this.form.sugestoes,
            data: this.form.data,
            estado: this.form.estado,
          });
        console.log(JSON.stringify(resposta.data));
        this.dialog1 = false;
      }
      catch(e){
        console.log("erro: " + e);
      }
    },
  },
  computed: {
    recebidas: function () {
      return this.sugestoesl.filter(function (sugestao) {
          return (sugestao.estado === "Não Lida" | sugestao.estado === "Lida")
      })
    }, 
    apagadas: function () {
      return this.sugestoesl.filter(function (sugestao) {
          return (sugestao.estado === "Apagada")
      })
    }, 
    enviadas: function () {
      return this.sugestoesl.filter(function (sugestao) {
          return (sugestao.estado === "Enviada")
      })
    }, 
    numero: function(){
      return this.sugestoesl.apagadas().length;
    }, 
  },
  components: {
    NavbarAdmin,
    Footer
  },
  created: async function(){
        try {
            let response = await axios.get(lhost + "/api/Sugestoes");
            this.sugestoesl = response.data;
            this.ready = true;
        } 
        catch (e) {
        return e;
        }
    },   

};
</script>

<style></style>