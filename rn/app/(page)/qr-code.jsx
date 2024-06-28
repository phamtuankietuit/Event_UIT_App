import { TouchableOpacity, View, Text, Image } from "react-native"
import { AntDesign } from "@expo/vector-icons"

const background = require("../../assets/images/QrBg-transformed.png")
const photoGallery = require("../../assets/images/photo-gallery.png")
const qrContainer = require("../../assets/images/QrContainer.jpg")
const Logo = require("../../assets/images/Logo-transparent.png")

import { Feather } from "@expo/vector-icons"

const QRCodeScreen = () => {
  return (
    <View className='flex-1 bg-white '>
      <Image
        source={qrContainer}
        className='absolute h-full w-full  transform opacity-60'
        style={{ resizeMode: "cover" }}
      ></Image>
      <View className='absolute mt-4 w-full flex-row items-center pl-3'>
        <TouchableOpacity>
          <AntDesign name='arrowleft' size={28} color='#333' />
        </TouchableOpacity>
        <Text className='ml-1 text-2xl font-semibold text-[#333]'> QR điểm danh</Text>
      </View>
      <View className='flex-1 items-center justify-center'>
        <View className='h-[70%] w-[80%] items-center justify-center'>
          <Image
            source={background}
            className='absolute h-full w-full rounded-3xl '
          ></Image>
          <View className='absolute top-9 h-[80] w-[80]'>
            <Image source={Logo} className='absolute h-full w-full' />
          </View>
          <View className='h-[250] w-[250] rounded-lg  bg-white shadow-md shadow-slate-800'></View>
        </View>
      </View>

      <View className='absolute bottom-0 h-[180] w-full items-center bg-white pt-5'>
        <TouchableOpacity className='items-center justify-center'>
          <Feather name='image' size={40} color='#0284D9' />
          <Text className='text-base font-semibold'>Lưu vào thư viện</Text>
        </TouchableOpacity>
      </View>
    </View>
  )
}

export default QRCodeScreen
