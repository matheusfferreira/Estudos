<template>
  <v-content>
    <v-container fluid fill-height>
      <v-layout align-center justify-center>
        <v-flex xs12 sm8 md4 lg4>
          <v-form @submit.prevent="insert">
            <v-text-field label="nome" required v-model="payload.nome"></v-text-field>
            <v-text-field label="email" required v-model="payload.email"></v-text-field>
            <v-btn type="submit">add</v-btn>
          </v-form>
        </v-flex>
      </v-layout>
    </v-container>
  </v-content>
</template>

<script>
import { pessoaAPI } from './API/PessoaAPI';

export default {
  data() {
    return {
      payload: { nome: '', email: '' },
    };
  },
  methods: {
    insert() {
      pessoaAPI.create(this.payload);
    },
  },
};
</script>
