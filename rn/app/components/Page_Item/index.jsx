import React from "react"
import { Image, Text, TouchableOpacity, View } from "react-native"
import logo from "../../../assets/images/Logo.png"
import { FontAwesomeIcon } from "@fortawesome/react-native-fontawesome"
import { faThumbsUp } from "@fortawesome/free-solid-svg-icons"
const Page_Item = ({ item, setLike }) => {
  return (
    <TouchableOpacity
      className='m-2 flex h-[100px] w-[98%] flex-row items-center rounded-lg bg-white p-1'
      style={{
        shadowColor: "#000",
        shadowOffset: {
          width: 0,
          height: 2,
        },
        shadowOpacity: 0.23,
        shadowRadius: 2.62,

        elevation: 4,
      }}
    >
      <View className='text-wrap flex h-[100%] w-[25%] items-center justify-center'>
        <Image
          source={logo}
          className='mr-4 h-[90%] w-[75%] rounded-full bg-white '
        />
      </View>

      <View className='flex h-[100%] w-[55%] justify-between pt-2'>
        <View className='relative mb-4 mt-2'>
          <Text className='text-[16px] font-semibold'>{item.namePage}</Text>
        </View>
        <Text className='mb-7 text-[13px]'>
          {item.star}
          <Text> Lượt thích</Text>
        </Text>
      </View>
      <View className='mr-2 flex h-[100%] w-[20%] items-center justify-center'>
        {item.like === true ? (
          <TouchableOpacity
            className='flex flex-row rounded-lg bg-slate-200 p-2'
            onPress={() => setLike(item.id, false)}
          >
            <FontAwesomeIcon icon={faThumbsUp} color='#64748b' />
            <Text className=' text-slate-500'> Đã thích</Text>
          </TouchableOpacity>
        ) : (
          <TouchableOpacity
            className='flex flex-row rounded-lg bg-cyan-200 p-2 '
            onPress={() => setLike(item.id, true)}
          >
            <FontAwesomeIcon icon={faThumbsUp} color='#06b6d4' />
            <Text className=' text-cyan-500'> Thích</Text>
          </TouchableOpacity>
        )}
      </View>
    </TouchableOpacity>
  )
}

export default Page_Item
