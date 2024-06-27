import { Image, Text, TouchableOpacity, View } from "react-native"
import logo from "../../../assets/images/Logo.png"
import { FontAwesomeIcon } from "@fortawesome/react-native-fontawesome"
import { faEllipsis } from "@fortawesome/free-solid-svg-icons"
const Post_Item = ({ item }) => {
  return (
    <View
      className='mx-2 my-1 flex w-[97%] rounded-lg bg-white p-3'
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
      <View className='flex h-[70px] flex-row justify-center '>
        <View className='flex w-[20%] items-center'>
          <Image
            source={logo}
            className='me-4 h-[75%] w-[75%] rounded-full bg-white '
            resizeMode='contain'
          />
        </View>
        <View className='w-[70%]'>
          <Text className='mb-2 text-[18px] font-semibold'>
            {item.namePage}
          </Text>
          <Text>10h trước</Text>
        </View>
        <View className='flex w-[10%] items-center'>
          <TouchableOpacity>
            <FontAwesomeIcon icon={faEllipsis} color='#64748b' />
          </TouchableOpacity>
        </View>
      </View>
      <View>
        <Text className='px-3' numberOfLines={2}>
          {item.content}
        </Text>
        <TouchableOpacity className='mb-7 px-3'>
          <Text className='text-blue-500'>Xem thêm ...</Text>
        </TouchableOpacity>
        <View className='flex flex-row flex-wrap items-center gap-3'>
          {item.images.map((item, index) => (
            <Image
              key={index}
              source={logo}
              className='h-[100px] w-[30%]'
              resizeMode='contain'
            />
          ))}
        </View>
      </View>
      <View className='flex flex-row items-center justify-center'>
        <Text>145 người đã tham gia</Text>
      </View>
      <View className='my-2 h-[1px] w-[100%] bg-slate-300' />
      <View className='flex flex-row items-center justify-center'>
        <TouchableOpacity className='my-3 flex w-[60%] items-center justify-center rounded-2xl bg-blue-500 px-3 py-3'>
          <Text className='text-white'>Tham gia sự kiện</Text>
        </TouchableOpacity>
      </View>
    </View>
  )
}

export default Post_Item
