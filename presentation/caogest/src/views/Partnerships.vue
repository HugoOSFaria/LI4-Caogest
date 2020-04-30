<template>
    <div id = "partnerships" class = "Partnerships">
        <NavbarKennel/>
        <v-card> 
            <v-img src='../assets/parcerias.png'></v-img> 
        </v-card>
        <v-card flat height= "100" color = "white"></v-card>
        
        <v-card flat class="mx-auto" max-width="1700" fluid>
            <v-card-text class=" display-1"> A CãoGest pretende expressar o seu agradecimento a todos os voluntários e empresas que se predispõem para auxiliar os canis registados nesta plataforma, tanto em trabalho como financeiramente.</v-card-text> 
        </v-card>

        <v-card flat class = "mx-auto" height= "200" color = "white"></v-card>

       <v-container>
            <v-row>
                <v-col v-for="item in items" :key = "item.nome" cols="12" md="4" >
                    <v-card
                        color="white"
                        class="d-flex align-center"
                        dark
                        flat
                        height="600"
                    >
                        <v-col>
                            <v-row>
                                <v-img max-height = "300" src = "../assets/alturacao.png" contain></v-img>
                            </v-row>
                            
                            <v-card flat height= "30" color = "white"></v-card>
                            
                            <v-row align = "center" justify = "center">
                                <v-btn class = "display-1" text light >{{item.nome}}</v-btn>
                            </v-row>

                            <v-card flat height= "30" color = "white"></v-card>
                        </v-col>
                    </v-card>
                </v-col>
            </v-row>
        </v-container>
        <Footer/>
    </div>
</template>

<script>
import NavbarKennel from '../components/NavbarKennel.vue'
import Footer from '../components/Footer.vue'
 
export default {
    data: () => ({             
        items: [
        {
          src: '../assets/alturacao.png',
          nome: 'Parceria1',
        },
        {
          src: '../assets/behaviour.png',
          nome: 'Parceria2',
        },
        {
          src: '../assets/pets.png',
          nome: 'Parceria3',
        },
        {
          src: '../assets/sad2.png',
          nome: 'Parceria4',
        },
      ],
      selected: [],   
    }),
    components: {
                NavbarKennel, 
                Footer
    }, 
    
}
</script>