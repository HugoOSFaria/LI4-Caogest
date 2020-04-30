<template>
    <div id = "donationskennel" class = "donationsKennel">
        <NavbarAdmin/>
            <v-card> 
                <v-img src='../assets/donativosrealizados.png'></v-img>
            </v-card>
            <v-card flat height= "150" color = "white"></v-card>

                <v-container class="my-5">
                    <v-layout row class="mb-3"> 
                        <v-tooltip top>
                            <template v-slot:activator="{ on }">
                                <v-btn class = "ma-2" text @click="sortBy('valor')" v-on="on">
                                    <v-icon left small>euro</v-icon>    
                                    <span class = "caption text-lowercase">Por quantia</span>
                                </v-btn>  
                            </template>
                            <span>Ordenar pedidos por quantia doada</span> 
                        </v-tooltip>

                        <v-tooltip top>
                            <template v-slot:activator="{ on }">
                                <v-btn class = "ma-2" text @click="sortBy('canil')" v-on="on">
                                    <v-icon left small>pets</v-icon>    
                                    <span class = "caption text-lowercase">Por canil</span>
                                </v-btn>  
                            </template>
                            <span>Ordenar pedidos por canil de doação realizada</span> 
                        </v-tooltip>

                        <v-tooltip top>    
                            <template v-slot:activator="{ on }">
                                <v-btn class = "ma-2" text @click="sortBy('data')" v-on="on">
                                    <v-icon left small>today</v-icon>    
                                    <span class = "caption text-lowercase">Por data</span>
                                </v-btn> 
                            </template>
                            <span>Ordenar pedidos por data de submissão</span>
                        </v-tooltip>    
                    </v-layout>

                <v-card flat v-for="donativo in donativos" :key="donativo.nome">
                    <v-layout row wrap class="pa-7 donativo">
                    <v-flex xs4 sm3>
                        <div class="caption grey--text">Nome Donatário</div>
                        <div>{{ donativo.nome }}</div>
                    </v-flex>
                    <v-flex xs4 sm3>
                        <div class="caption grey--text">Nome Canil</div>
                        <div>{{ donativo.canil }}</div>
                    </v-flex>
                    <v-flex xs4 sm3>
                        <div class="caption grey--text">Data</div>
                        <div>{{ donativo.data }}</div>
                    </v-flex>
                    <v-flex xs4 sm3>
                        <div class="caption grey--text">Valor do Donativo</div>
                        <div>{{ donativo.valor }}</div>
                    </v-flex>
                    </v-layout>
                    <v-divider></v-divider>
                </v-card>
                </v-container>
        <Footer/>
    </div>
</template>

<script>
import NavbarAdmin from '../components/NavbarAdmin.vue'
import Footer from '../components/Footer.vue'

export default {
  data() {
    return {
      donativos: [
        { nome: 'João Sousa', canil: 'Canil1', data: '10th Jan 2010', valor: 1500},
        { nome: 'Maria Alves', canil: 'Patinhas Canil', data: '15th Feb 2018', valor: 200},
        { nome: 'Vitor Fonseca', canil: 'Canil 213', data: '4th Dec 2019', valor: 10},
        { nome: 'Cristina Martins', canil: 'Canil Ajuda', data: '27th Aug 2019', valor: 35},
      ]
    };
  },
  methods: {
    sortBy(prop){
          this.donativos.sort((a,b) => a[prop] < b[prop] ? -1 : 1)
    },
    }, 
     components: {
                NavbarAdmin, 
                Footer,
    }, 
};
</script>

<style>

</style>
