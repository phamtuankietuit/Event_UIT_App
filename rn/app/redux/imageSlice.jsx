// imageSlice.js
import { createSlice } from '@reduxjs/toolkit';

const initialState = {
  fullScreenImage: null,
};

const imageSlice = createSlice({
  name: 'image',
  initialState,
  reducers: {
    setFullScreenImage(state, action) {
      state.fullScreenImage = action.payload;
    },
    clearFullScreenImage(state) {
      state.fullScreenImage = null;
    },
  },
});

export const { setFullScreenImage, clearFullScreenImage } = imageSlice.actions;
export default imageSlice.reducer;