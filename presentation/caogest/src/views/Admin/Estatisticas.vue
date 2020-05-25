<template>
    <div id="entreemcontacto" class="entreemcontacto">
        <NavbarAdmin />
        <v-card>
            <v-img src="@/assets/estatisticas.png"></v-img>
        </v-card>
        <v-card flat height="150" color="white"></v-card>

        <v-container fluid grid-list-md>
            <v-layout row wrap>
            <v-flex
                md3
                sm6
                xs12
                full
                v-for="(stat, index) in stats"
                v-bind:key="index"
            >
                <v-card :class="stat.bgColor" dark>
                <v-container fluid grid-list-sm dark>
                    <v-layout class="mt-6 mb-6 mx-6" row wrap>
                    <v-flex sm3 hidden-xs-only>
                        <v-icon class="mx-0" x-large dark>{{ stat.icon }}</v-icon>
                    </v-flex>
                    <v-flex sm9 xs12>
                        <v-layout class="mt-0 mb-0 pa-0" row wrap>
                        <v-flex d-flex xs12>
                            <div class="silver--text headline">{{ stat.title }}</div>
                        </v-flex>
                        <v-flex d-flex xs12 class="mx-4">
                            <div class="silver--text display-1">{{ stat.data }}</div>
                            &nbsp;&nbsp;
                            
                        </v-flex>
                        </v-layout>
                    </v-flex>
                    </v-layout>
                </v-container>
                </v-card>
            </v-flex>
            </v-layout>
        </v-container>
        <Footer/>
    </div>    
</template>

<script>
import NavbarAdmin from '@/components/NavbarFooter/NavbarAdmin.vue'
import Footer from '@/components/NavbarFooter/Footer.vue'
import axios from 'axios'
const lhost = require("@/config/global").host;

export default {
    data: () => ({
        stats: [],
    }),
    name: 'Estatistica',
    props: ['id'], 
    components: { NavbarAdmin, 
                  Footer,
    },
    mounted() {
    this.getNumeroUtilizadores();
    this.getNumeroCaes();
    this.getNumeroVoluntarios();
    this.getNumeroAdocoes();
    },
    methods: {
        async getNumeroUtilizadores() {
        await axios.get(lhost + "/api/Stats/Users")
        .then (
        response => {
          this.stats.push({
            bgColor: "brown darken-2",
            icon: "person",
            title: "Número de Utilizadores Registados",
            data: response.data - 1,
        });
        })
        .catch(error => console.log(JSON.stringify(error)));
        },
        async getNumeroCaes() {
        await axios.get(lhost + "/api/Stats/Caes")
            .then(res => {
                this.stats.push({
                    bgColor: "brown darken-2",
                    icon: "pets",
                    title: "Número de Cães Registados",
                    data: res.data,
                });
                })
            .catch(error => console.log(JSON.stringify(error)));
        },
        async getNumeroVoluntarios() {
        await axios.get(lhost + "/api/Stats/Voluntarios")
            .then(res => {
            this.stats.push({
                bgColor: "brown darken-2",
                icon: "accessibility_new",
                title: "Número de Voluntários",
                data: res.data,
            });
            })
            .catch(error => console.log(JSON.stringify(error)));
        },
        async getNumeroAdocoes() {
        await axios.get(lhost + "/api/Stats/Adocoes")
            .then(res => {
            this.stats.push({
                bgColor: "brown darken-2",
                icon: "home",
                title: "Número de Adoções Realizadas",
                data: res.data,
            });
            })
            .catch(error => console.log(JSON.stringify(error)));
        },
    },
}
</script>

<style>
#Estatistica {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
