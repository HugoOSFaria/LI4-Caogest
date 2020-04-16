<template>
    <div id = "mainpage" class = "Main Page">
        <Navbar/>
        <v-card flat height= "80" color = "white"></v-card>
        <v-container>
        <AdoptionRequest/>
        <Footer/>
        </v-container>
    </div>
</template>

<script>
import Navbar from '../components/Navbar.vue'
import Footer from '../components/Footer.vue'
import AdoptionRequest from '../components/AdoptionRequest.vue'
export default {
    components: { Navbar, 
                  Footer,
                  AdoptionRequest}
}
</script>