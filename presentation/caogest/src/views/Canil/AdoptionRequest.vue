<template>
    <div id = "adoptionRequest" class = "Adoption Request">
        <NavbarKennel :id="$route.params.id"/>
         <v-card> 
            <v-img src='@/assets/pedidosadocaocanil.png'></v-img>
         </v-card>
        <v-card flat height= "80" color = "white"></v-card>
        <v-container>
            <AdoptionRequest :id="$route.params.id"/>
        </v-container>
                <Footer :id="$route.params.id"/>
    </div>
</template>

<script>
import NavbarKennel from '@/components/NavbarFooter/NavbarKennel.vue'
import Footer from '@/components/NavbarFooter/FooterKennel.vue'
import AdoptionRequest from '@/components/AdoptionRequest.vue'
export default {
    components: { NavbarKennel, 
                  Footer,
                  AdoptionRequest}
}
</script>