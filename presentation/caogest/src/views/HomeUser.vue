<template>
    <div id = "mainpage" class = "Main Page">
        <Navbar/>
    
        <v-carousel
            cycle
            height="750"
            hide-delimiter-background
            show-arrows-on-hover
        >
            <v-carousel-item src= '../assets/sad2.jpg'>
                <v-row
                    class="fill-height"
                    align="center"
                    justify="center"
                >
                    <div class="display-3 white--text">Todos os anos são acolhidos em canis dispersos pelo país cerca de 35 393 animais</div>
                </v-row>
            </v-carousel-item>
            <v-carousel-item src= '../assets/sad.jpg'>
                <v-row
                    class="fill-height"
                    align="center"
                    justify="center"
                >
                    <div class="display-3 white--text"> Por ano, são adotados apenas 36,6% dos animais acolhidos</div>
                </v-row>
            </v-carousel-item>
            <v-carousel-item src= '../assets/happy.jpg'>
                <v-row
                    class="fill-height"
                    align="center"
                    justify="center"
                >
                    <div class="display-3 white--text">Os cães ajudam a diminuir o stress dos donos.</div>
                </v-row>
            </v-carousel-item>
            <v-carousel-item src= '../assets/happy2.jpg'>
                <v-row
                    class="fill-height"
                    align="center"
                    justify="center"
                >
                    <div class="display-3 white--text">Cães acolhidos são mais sociáveis e interativos</div>
                </v-row>
            </v-carousel-item>
        </v-carousel>
    
        <v-container>
        <AdoptionRequest/>
        </v-container>
        <Footer/>
    </div>
</template>

<script>
import Navbar from '../components/Navbar.vue'
import Footer from '../components/Footer.vue'
import AdoptionRequest from '../components/AdoptionRequest.vue'
export default {
    data () {
      return {
        items: [
          {
            src: 'https://cdn.vuetifyjs.com/images/carousel/squirrel.jpg',
          },
          {
            src: 'https://cdn.vuetifyjs.com/images/carousel/sky.jpg',
          },
          {
            src: 'https://cdn.vuetifyjs.com/images/carousel/bird.jpg',
          },
          {
            src: 'https://cdn.vuetifyjs.com/images/carousel/planet.jpg',
          },
        ],
        slides: [
          'Todos os anos são acolhidos em canis dispersos pelo país aproximadamente 35393 animais',
          'Second',
          'Third',
          'Fourth',
          'Fifth',
        ],
      }
    },
    components: { Navbar, 
                  Footer,
                  AdoptionRequest}
}
</script>
