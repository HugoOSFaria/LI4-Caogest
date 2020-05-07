<template>
    <div id = "about" class = "About">
        <Navbar/>
        
        <About/>
          
        <Footer/>
    </div>
</template>

<script>
import Navbar from '@/components/NavbarFooter/Navbar.vue'
import Footer from '@/components/NavbarFooter/Footer.vue'
import About from '@/components/Infos/About.vue'
export default {
    components: {   Navbar, 
                    Footer,
                    About }
}
</script>