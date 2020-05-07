<template>
    <div id = "faqskennel" class = "FAQsKennel">
        <NavbarKennel/>
        <FAQs/>
        <Footer/>
    </div>
</template>


<script>
import NavbarKennel from '@/components/NavbarFooter/NavbarKennel.vue'
import Footer from '@/components/NavbarFooter/FooterKennel.vue'
import FAQs from '@/components/Infos/FAQs.vue'
 
export default {
    components: {
                NavbarKennel, 
                Footer,
                FAQs
    }, 
    
}
</script>